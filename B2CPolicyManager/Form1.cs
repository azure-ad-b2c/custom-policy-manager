using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Web;

namespace B2CPolicyManager
{
    public partial class B2CPolicyManager : Form
    {
        List<string> sortedList = new List<string>();
        List<App> finalAppList = new List<App>();
        public B2CPolicyManager()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
        FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (policyFolderLbl.Text != null)
            {
                fbd.SelectedPath = policyFolderLbl.Text;
            }
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.Folder = fbd.SelectedPath;
                Properties.Settings.Default.Save();
                policyFolderLbl.Text = fbd.SelectedPath;
                checkedPolicyList.Items.Clear();
                //var ext = new List<string> { ".xml" };
                //string[] fileEntries = Directory.GetFiles(policyFolderLbl.Text).Select(p => Path.GetFileName(p)..Where(fn => Path.GetExtension(fn) == ".xml")

                var allFilenames = Directory.EnumerateFiles(policyFolderLbl.Text).Select(p => Path.GetFileName(p));

                // Get all filenames that have a .txt extension, excluding the extension
                var fileEntries = allFilenames.Where(fn => Path.GetExtension(fn) == ".xml")
                                             .Select(fn => Path.GetFileName(fn))
                                             .ToArray();


                foreach (string file in fileEntries)
                {
                    checkedPolicyList.Items.Add(file);
                }
            }
        }

        private async void LoginBtn_Click(object sender, EventArgs e)
        {
            if (loginBtn.Text == "Login"){
                //Task<string> token = AuthenticationHelper.GetTokenForUserAsync();
                string token = await AuthenticationHelper.GetTokenForUserAsync();
                if (token != null)
                {
                    loginBtn.Text = "Logout";
                    DateTime thisDayLogin = DateTime.Now;

                    HTTPResponse.AppendText("\r\n" + thisDayLogin.ToString() + " - Logged in, getting policies.\r\n");
                    HttpResponseMessage response = null;
                    response = await UserMode.HttpGetAsync(Constants.TrustFrameworkPolicesUri);
                    string content = await response.Content.ReadAsStringAsync();
                    //HTTPResponse.AppendText(await response.Content.ReadAsStringAsync());
                    PolicyList pL = JsonConvert.DeserializeObject<PolicyList>(content);

                    UpdatePolicyList(pL);
                    List<App> finalApplist = await RefreshAppListAsync();
                    foreach (App app in finalApplist)
                    {
                        appList.Items.Add(app.displayName);
                    }
                }
            }
            else
            {
                loginBtn.Text = "Login";
                AuthenticationHelper.ClearCache();
                policyList.Items.Clear();
            }
        }

        private async void ListBtn_ClickAsync(object sender, EventArgs e)
        {
            string token = await AuthenticationHelper.GetTokenForUserAsync();
            if (token != null)
            {
                DateTime thisDay = DateTime.Now;

                HTTPResponse.AppendText("\r\n" + thisDay.ToString() + " - Getting policies.\r\n");
                HttpResponseMessage response = null;
                response = await UserMode.HttpGetAsync(Constants.TrustFrameworkPolicesUri);
                string content = await response.Content.ReadAsStringAsync();
                //HTTPResponse.AppendText(JToken.Parse(content).ToString(Formatting.Indented));
                //HTTPResponse.AppendText(await response.Content.ReadAsStringAsync());

                if (response.IsSuccessStatusCode == true)
                {
                    DateTime thisDayGotList = DateTime.Now;

                    HTTPResponse.AppendText("\r\n" + thisDayGotList.ToString() + " - Successfully updated policy list.\r\n");
                }
                else
                {
                    HTTPResponse.AppendText(content);
                }


                PolicyList pL = JsonConvert.DeserializeObject<PolicyList>(content);

                UpdatePolicyList(pL);
            }
        }

        private async void DeleteSelectedBtn_Click(object sender, EventArgs e)
        {

            if (policyList.SelectedItem != null)
            {
                string token = await AuthenticationHelper.GetTokenForUserAsync();
                if (token != null)
                {
                    DateTime thisDay = DateTime.Now;

                    HTTPResponse.AppendText("\r\n" + thisDay.ToString() + " - Deleting " + policyList.SelectedItem.ToString() +"\r\n");
                    HttpResponseMessage response = null;
                    response = await UserMode.HttpDeleteIDAsync(Constants.TrustFrameworkPolicesUri, Constants.TrustFrameworkPolicyByIDUri, policyList.SelectedItem.ToString().ToUpper());
                    string content = await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode == true)
                    {
                        DateTime thisDayItem = DateTime.Now;

                        HTTPResponse.AppendText("\r\n" + thisDayItem.ToString() + " - Successfully deleted " + policyList.SelectedItem.ToString() + "\r\n");
                    }
                    else
                    {
                        HTTPResponse.AppendText(content);
                    }

                    //HTTPResponse.AppendText(await response.Content.ReadAsStringAsync());
                    response = await UserMode.HttpGetAsync(Constants.TrustFrameworkPolicesUri);
                    content = await response.Content.ReadAsStringAsync();
                    //HTTPResponse.AppendText(await response.Content.ReadAsStringAsync());
                    if (response.IsSuccessStatusCode == true)
                    {
                        DateTime thisDayUpdate = DateTime.Now;

                        HTTPResponse.AppendText("\r\n" + thisDayUpdate.ToString() + " - Successfully updated policy list.\r\n");
                    }
                    else
                    {
                        HTTPResponse.AppendText(content);
                    }
                    PolicyList pL = JsonConvert.DeserializeObject<PolicyList>(content);
                    UpdatePolicyList(pL);
                }
            }
        }

        private void UpdatePolicyList(PolicyList myPolicies)
        {

            policyList.Items.Clear();
            CultureInfo culture = new CultureInfo("en-GB", false);
            List<string> unsortedList = new List<string>();

            if (myPolicies.Value != null)
            {
                foreach (Value policyValue in myPolicies.Value)
                {
                    if (showRPs.Checked)
                    {
                        if (!policyValue.Id.Contains("BASE") && !policyValue.Id.Contains("EXTENSIONS"))// && (culture.CompareInfo.IndexOf(policyValue.Id, policyListFilter.Text, CompareOptions.IgnoreCase) >= 0))
                        {
                            unsortedList.Add(policyValue.Id);
                        }
                    }
                    else
                    {
                        unsortedList.Add(policyValue.Id);
                    }
                }

                sortedList = unsortedList.OrderBy(x => x).ToList();

                foreach (string policyValue in sortedList)
                {
                    if (policyListFilter.Text != null)
                    {
                        if (culture.CompareInfo.IndexOf(policyValue, policyListFilter.Text, CompareOptions.IgnoreCase) >= 0)

                        {
                            string policyValueLower = policyValue.ToLower();
                            policyList.Items.Add(policyValueLower);
                        }
                    }
                    if (policyListFilter.Text == null)
                    {
                        string policyValueLower = policyValue.ToLower();
                        policyList.Items.Add(policyValueLower);

                    }

                }
            }
            else
            {
                HTTPResponse.AppendText("\r\n" + DateTime.Now.ToString() + " - There are no custom policy files available in the tenant.\r\n");
            }
        }

        private async void DeleteAllBtn_Click(object sender, EventArgs e)
        {
            string token = await AuthenticationHelper.GetTokenForUserAsync();
            if (token != null)
            {
                DateTime thisDay = DateTime.Now;

                HTTPResponse.AppendText("\r\n" + thisDay.ToString() + " - Deleting all custom polices from B2C.\r\n");
                HttpResponseMessage response = null;
                response = await UserMode.HttpGetAsync(Constants.TrustFrameworkPolicesUri);
                HTTPResponse.AppendText(await response.Content.ReadAsStringAsync());
                string content = await response.Content.ReadAsStringAsync();
                PolicyList pL = JsonConvert.DeserializeObject<PolicyList>(content);
                foreach (Value policyValue in pL.Value)
                {
                    response = await UserMode.HttpDeleteIDAsync(Constants.TrustFrameworkPolicesUri, Constants.TrustFrameworkPolicyByIDUri, policyValue.Id);
                    string  log = await response.Content.ReadAsStringAsync();
                    if (response.IsSuccessStatusCode == true)
                    {
                        DateTime thisDayDeleted = DateTime.Now;

                        HTTPResponse.AppendText("\r\n" + thisDayDeleted.ToString() + " - Successfully deleted " + policyValue.ToString() + "\r\n");
                    }
                    else
                    {
                        HTTPResponse.AppendText(log);
                    }

                }

                response = null;
                response = await UserMode.HttpGetAsync(Constants.TrustFrameworkPolicesUri);
                //HTTPResponse.AppendText(await response.Content.ReadAsStringAsync());
                content = await response.Content.ReadAsStringAsync();
                pL = JsonConvert.DeserializeObject<PolicyList>(content);
                UpdatePolicyList(pL);
            }
        }

        private async void UploadFolderBtn_Click(object sender, EventArgs e)
        {
            /*if (policyFolderLbl.Text != "No Folder selected.")
            {
                HTTPResponse.AppendText("\r\nUploading selected policies\r\n");
                string token = await AuthenticationHelper.GetTokenForUserAsync();
                if (token != null)
                {
                    HttpResponseMessage response = null;
                    string[] fileEntries = checkedPolicyList.CheckedItems.OfType<string>().ToArray();
                    List<string> fileList = new List<string>(fileEntries);

                    //if we found ext file, move to top
                    var regexExtensions = @"\w*Extensions\w*";
                    var indexExtensions = -1;
                    indexExtensions = fileList.FindIndex(d => regexExtensions.Any(s => Regex.IsMatch(d.ToString(), regexExtensions)));
                    if (indexExtensions > -1)
                    {
                        fileList.Insert(0, fileList[indexExtensions]);
                        fileList.RemoveAt(indexExtensions + 1);
                    }

                    //if we found base file, move to top
                    var regexBase = @"\w*Base\w*";
                    var indexBase = -1;
                    indexBase = fileList.FindIndex(d => regexBase.Any(s => Regex.IsMatch(d.ToString(), regexBase)));
                    if (indexBase > -1)
                    {
                        fileList.Insert(0, fileList[indexBase]);
                        fileList.RemoveAt(indexBase + 1);
                    }

                    foreach (string file in fileList)
                    {
                        HTTPResponse.AppendText(String.Format("Uploading: {0}", file));
                    }
                    foreach (string file in fileList)
                    {
                        string xml = File.ReadAllText(policyFolderLbl.Text + @"\" + file);
                        response = await UserMode.HttpPostAsync(Constants.TrustFrameworkPolicesUri, xml);
                        if (response.IsSuccessStatusCode == false)
                        {
                            HTTPResponse.AppendText(await response.Content.ReadAsStringAsync());
                        }
                        else
                        {
                            HTTPResponse.AppendText("\r\nSuccefully uploaded " + file +"\r\n");
                        }
                    }

                    response = await UserMode.HttpGetAsync(Constants.TrustFrameworkPolicesUri);
                    string content = await response.Content.ReadAsStringAsync();
                    //HTTPResponse.AppendText(await response.Content.ReadAsStringAsync());
                    if (response.IsSuccessStatusCode == true)
                    {
                        HTTPResponse.AppendText("\r\nSuccessfully updated policy list.\r\n");
                    }
                    else
                    {
                        HTTPResponse.AppendText(content);
                    }

                    PolicyList pL = JsonConvert.DeserializeObject<PolicyList>(content);

                    UpdatePolicyList(pL);
                }
            }*/
        }

        private async void UpdateAllPolicesBtn_Click(object sender, EventArgs e)
        {

            if (policyFolderLbl.Text != "No Folder selected.")
            {
                DateTime thisDay = DateTime.Now;

                HTTPResponse.AppendText("\r\n" + thisDay.ToString() + " - Updating selected policies.\r\n");
                string token = await AuthenticationHelper.GetTokenForUserAsync();
                if (token != null)
                { 
                    HttpResponseMessage response = null;
                    string[] fileEntries = checkedPolicyList.CheckedItems.OfType<string>().ToArray();
                    List<string> fileList = new List<string>(fileEntries);

                    //if we found ext file, move to top
                    var regexExtensions = @"\w*Extensions\w*";
                    var indexExtensions = -1;
                    indexExtensions = fileList.FindIndex(d => regexExtensions.Any(s => Regex.IsMatch(d.ToString(), regexExtensions)));
                    if (indexExtensions > -1)
                    {
                        fileList.Insert(0, fileList[indexExtensions]);
                        fileList.RemoveAt(indexExtensions + 1);
                    }

                    //if we found base file, move to top
                    var regexBase = @"\w*Base\w*";
                    var indexBase = -1;
                    indexBase = fileList.FindIndex(d => regexBase.Any(s => Regex.IsMatch(d.ToString(), regexBase)));
                    if (indexBase > -1)
                    {
                        fileList.Insert(0, fileList[indexBase]);
                        fileList.RemoveAt(indexBase + 1);
                    }


                    foreach (string file in fileList)
                    {
                        string xml = File.ReadAllText(policyFolderLbl.Text + @"\" + file);
                        string fileName = file.Split('.')[0];

                        //Get actual policy id
                        XDocument policyFile = XDocument.Parse(xml);
                        string id = policyFile.Root.Attribute("PolicyId").Value;

                        response = await UserMode.HttpPutIDAsync(Constants.TrustFrameworkPolicyByIDUriPUT, id, xml);
                        if (response.IsSuccessStatusCode == false)
                        {
                            string errContent = await response.Content.ReadAsStringAsync();
                            uploadPolicyResponseError errorMsg = JsonConvert.DeserializeObject<uploadPolicyResponseError>(errContent);
                            HTTPResponse.AppendText("\r\n" + errorMsg.error.message + "\r\n\r\n CorrelationId:" + errorMsg.error.innerError.correlationId + "\r\n Timestamp:" + errorMsg.error.innerError.date + "\r\n");
                        }
                        else
                        {
                            DateTime thisDayUpdated = DateTime.Now;

                            HTTPResponse.AppendText("\r\n" + thisDayUpdated.ToString() + " - Successfully updated " + file + "\r\n");
                        }
                    }

                    response = await UserMode.HttpGetAsync(Constants.TrustFrameworkPolicesUri);
                    string content = await response.Content.ReadAsStringAsync();
                    //HTTPResponse.AppendText(await response.Content.ReadAsStringAsync());
                    if (response.IsSuccessStatusCode == true)
                    {
                        PolicyList pL = JsonConvert.DeserializeObject<PolicyList>(content);

                        UpdatePolicyList(pL);
                        DateTime thisDayUpdateList = DateTime.Now;

                        HTTPResponse.AppendText("\r\n" + thisDayUpdateList.ToString() + " - Successfully updated policy list.\r\n");
                    }
                    else
                    {
                        HTTPResponse.AppendText(content);
                    }
                    
                }
            }

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RefrshFileListBtn_Click(object sender, EventArgs e)
        {
            if (policyFolderLbl.Text != "No Folder selected.")
            {
                checkedPolicyList.Items.Clear();
                var allFilenames = Directory.EnumerateFiles(policyFolderLbl.Text).Select(p => Path.GetFileName(p));

                // Get all filenames that have a .txt extension, excluding the extension
                var fileEntries = allFilenames.Where(fn => Path.GetExtension(fn) == ".xml")
                                             .Select(fn => Path.GetFileName(fn))
                                             .ToArray();
                foreach (string file in fileEntries)
                {
                    checkedPolicyList.Items.Add(file);
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (RunNowtxt.Text != "")
            {
                Clipboard.SetText(RunNowtxt.Text);
            }
        }





        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (policyList.SelectedItem != null)
            {
                RunNowtxt.Text = string.Format("https://login.microsoftonline.com/{0}/oauth2/v2.0/authorize?p={1}&client_id={2}&nonce=defaultNonce&redirect_uri={3}&scope=openid&response_type=id_token&prompt=login&disable_cache=true", tenantTxt.Text, policyList.SelectedItem.ToString(), appList.SelectedItem, replyUrl.SelectedItem);
            }
            Properties.Settings.Default.TenantId = tenantTxt.Text;
            Properties.Settings.Default.Save();
        }



        private void policyList_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateRunNow();
        }

        private void updateRunNow()
        {

            if (policyList.SelectedItem != null)
            {
                if (appList.SelectedItem != null && tenantTxt.Text != null && tenantTxt.Text != "" && getAccessToken.Checked && b2cResource.Text != "")
                {
                    List<App> apps = finalAppList.Where(a => a.displayName == appList.SelectedItem).ToList();
                    string appId = apps[0].appId;
                    Regex regex = new Regex(@"\w*");
                    Match match = regex.Match(tenantTxt.Text);
                    RunNowtxt.Text = string.Format("https://{0}.b2clogin.com/{1}/oauth2/v2.0/authorize?p={2}&client_id={3}&nonce=defaultNonce&redirect_uri={4}&scope=openid {5}&response_type=id_token token&prompt=login&disable_cache=true", match.Value, tenantTxt.Text, policyList.SelectedItem.ToString(), appId, replyUrl.SelectedItem, b2cResource.Text);
                }
                else if (appList.SelectedItem != null && tenantTxt.Text != null && tenantTxt.Text != "" && !getAccessToken.Checked)
                {
                    List<App> apps = finalAppList.Where(a => a.displayName == appList.SelectedItem).ToList();
                    string appId = apps[0].appId;
                    Regex regex = new Regex(@"\w*");
                    Match match = regex.Match(tenantTxt.Text);
                    RunNowtxt.Text = string.Format("https://{0}.b2clogin.com/{1}/oauth2/v2.0/authorize?p={2}&client_id={3}&nonce=defaultNonce&redirect_uri={4}&scope=openid&response_type=id_token&prompt=login&disable_cache=true", match.Value, tenantTxt.Text, policyList.SelectedItem.ToString(), appId, replyUrl.SelectedItem);
                }
                else
                {
                    RunNowtxt.Text = string.Format("https://login.microsoftonline.com/{0}/oauth2/v2.0/authorize?p={1}&client_id={2}&nonce=defaultNonce&redirect_uri={3}&scope=openid&response_type=id_token&prompt=login&disable_cache=true", tenantTxt.Text, policyList.SelectedItem.ToString(), appList.SelectedItem, replyUrl.SelectedItem);
                }
            }
        }

        private void B2CPolicyManager_Load(object sender, EventArgs e)
        {
            this.appList.SelectedItem = Properties.Settings.Default.B2CAppId;
            this.tenantTxt.Text = Properties.Settings.Default.TenantId;
            this.v2AppIDGraphtxt.Text = Properties.Settings.Default.V2AppId;
            this.replyUrl.SelectedItem = Properties.Settings.Default.ReplyUrl;
            this.policyFolderLbl.Text = Properties.Settings.Default.Folder;
            this.showRPs.Checked = Properties.Settings.Default.ShowRPs;
            this.getAccessToken.Checked = Properties.Settings.Default.GetAccessToken;
            this.b2cResource.Text = Properties.Settings.Default.Resource;

            if (this.policyFolderLbl.Text != "No Folder selected.")
            {
                var allFilenames = Directory.EnumerateFiles(policyFolderLbl.Text).Select(p => Path.GetFileName(p));

                // Get all filenames that have a .txt extension, excluding the extension
                var fileEntries = allFilenames.Where(fn => Path.GetExtension(fn) == ".xml")
                                             .Select(fn => Path.GetFileName(fn))
                                             .ToArray();
                foreach (string file in fileEntries)
                {
                    checkedPolicyList.Items.Add(file);
                }
            }

        }

        private void v2AppIDGraphtxt_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.V2AppId = v2AppIDGraphtxt.Text;
            Properties.Settings.Default.Save();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HTTPResponse.Text = "";
        }

        private void VSCodeBtn_Click(object sender, EventArgs e)
        {
            if (this.policyFolderLbl.Text != "No Folder selected.")
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = string.Format("code"),
                    WindowStyle = ProcessWindowStyle.Hidden,
                    Arguments = string.Format("\"{0}\"", policyFolderLbl.Text)
                };
                Process.Start(startInfo);
            }
        }

        private void EdgeBtn_Click(object sender, EventArgs e)
        {
            string command = String.Format("start chrome --incognito --new-window \"{0}\"", RunNowtxt.Text);
            ProcessStartInfo startInfo = new ProcessStartInfo("cmd", "/c " + command)
            {
                WindowStyle = ProcessWindowStyle.Hidden
            };
            Process.Start(startInfo);
        }

        private void IEBtn_Click(object sender, EventArgs e)
        {
            string command = String.Format("start msedge.exe \"{0}\" -inPrivate", RunNowtxt.Text);
            ProcessStartInfo startInfo = new ProcessStartInfo("cmd", "/c " + command)
            {
                WindowStyle = ProcessWindowStyle.Hidden
            };
            Process.Start(startInfo);
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int elementCount = checkedPolicyList.Items.Count;
            for (int i = 0; i < elementCount; i++)
            {
                checkedPolicyList.SetItemChecked(i, true);
            }
        }

        private void deselectAllPolicies_Click(object sender, EventArgs e)
        {
            int elementCount = checkedPolicyList.Items.Count;
            for (int i = 0; i < elementCount; i++)
            {
                checkedPolicyList.SetItemChecked(i, false);
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"\w*");
            Match match = regex.Match(tenantTxt.Text);
            if (policyList.SelectedItem != null) {
                string url = "https://b2csamlrp.azurewebsites.net/SP/autoinitiate?" + "tenant=" + match.Value + "&policy=" + policyList.SelectedItem.ToString();
                string command = String.Format("start chrome --incognito --new-window \"{0}\"", url);
                ProcessStartInfo startInfo = new ProcessStartInfo("cmd", "/c " + command)
                {
                    WindowStyle = ProcessWindowStyle.Hidden
                };
                Process.Start(startInfo);
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
        }

        private void showRPs_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ShowRPs = showRPs.Checked;
            Properties.Settings.Default.Save();
        }

        private void getAccessToken_CheckedChanged(object sender, EventArgs e)
        {
            updateRunNow();
            Properties.Settings.Default.GetAccessToken = getAccessToken.Checked;
            Properties.Settings.Default.Save();
        }

        private void b2cResource_TextChanged(object sender, EventArgs e)
        {
            updateRunNow();
            Properties.Settings.Default.Resource = b2cResource.Text;
            Properties.Settings.Default.Save();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            policyList.Items.Clear();
            CultureInfo culture = new CultureInfo("en-GB", false);
            foreach (string policyValue in sortedList)
            {
                if (policyListFilter.Text != null)
                {
                    if (culture.CompareInfo.IndexOf(policyValue, policyListFilter.Text, CompareOptions.IgnoreCase) >= 0)

                    {
                        string policyValueLower = policyValue.ToLower();
                        policyList.Items.Add(policyValueLower);
                    }
                }
            }
        }

        private async void button3_Click_1(object sender, EventArgs e)
        {
            List<App> finalApplist = await RefreshAppListAsync();
            foreach (App app in finalApplist)
            {
                appList.Items.Add(app.displayName);
            }
        }

        private async Task<List<App>> RefreshAppListAsync()
        {
            DateTime thisDay = DateTime.Now;

            HTTPResponse.AppendText("\r\n" + thisDay.ToString() + " - Getting AAD B2C app registraions.\r\n");
            HttpResponseMessage response = null;
            response = await UserMode.HttpGetAsync("https://graph.microsoft.com/beta/applications");
            string content = await response.Content.ReadAsStringAsync();
            //HTTPResponse.AppendText(JToken.Parse(content).ToString(Formatting.Indented));
            //HTTPResponse.AppendText(await response.Content.ReadAsStringAsync());

            if (response.IsSuccessStatusCode == true)
            {
                DateTime thisDayGotList = DateTime.Now;
                AppList appList = JsonConvert.DeserializeObject<AppList>(content);

                List<App> sortedAppList = appList.value.OrderBy(o => o.displayName).ToList();
                
                foreach (App app in sortedAppList) { 
                    if (app.signInAudience == "AzureADandPersonalMicrosoftAccount")
                    {
                        finalAppList.Add(app);
                    }
                }

                HTTPResponse.AppendText("\r\n" + thisDayGotList.ToString() + " - Successfully updated app reg list.\r\n");
                return finalAppList;
            }
            else
            {
                HTTPResponse.AppendText(content);
                AppList appList = new AppList();
                List <App> finalAppList = new List<App>();
                return finalAppList;
            }

            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<App> apps = finalAppList.Where(a => a.displayName == appList.SelectedItem).ToList();
            string appId = apps[0].appId;
            replyUrl.Items.Clear();
            replyUrl.Text = "";
            if (apps[0].web.redirectUris!= null) { 

                foreach(string url in apps[0].web.redirectUris)
                {
                    replyUrl.Items.Add(url);
                }                    
            }

            if (appList.SelectedItem != null && replyUrl.SelectedItem != null && tenantTxt.Text != "" && getAccessToken.Checked && b2cResource.Text != "")
            {
                Regex regex = new Regex(@"\w*");
                Match match = regex.Match(tenantTxt.Text);
                RunNowtxt.Text = string.Format("https://{0}.b2clogin.com/{1}/oauth2/v2.0/authorize?p={2}&client_id={3}&nonce=defaultNonce&redirect_uri={4}&scope=openid {5}&response_type=id_token token&prompt=login&disable_cache=true", match.Value, tenantTxt.Text, policyList.SelectedItem.ToString(), appId, replyUrl.SelectedItem, b2cResource.Text);
            }
            else if (appList.SelectedItem != null && replyUrl.SelectedItem != null && tenantTxt.Text != "" && !getAccessToken.Checked)
            {
                Regex regex = new Regex(@"\w*");
                Match match = regex.Match(tenantTxt.Text);
                RunNowtxt.Text = string.Format("https://{0}.b2clogin.com/{1}/oauth2/v2.0/authorize?p={2}&client_id={3}&nonce=defaultNonce&redirect_uri={4}&scope=openid&response_type=id_token&prompt=login&disable_cache=true", match.Value, tenantTxt.Text, policyList.SelectedItem.ToString(), appId, replyUrl.SelectedItem);
            }

            Properties.Settings.Default.B2CAppId = apps[0].appId;
            Properties.Settings.Default.Save();

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void replyUrl_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<App> apps = finalAppList.Where(a => a.displayName == appList.SelectedItem).ToList();
            string appId = apps[0].appId;

            if (apps[0].web.redirectUris != null)
            {

                foreach (string url in apps[0].web.redirectUris)
                {
                    replyUrl.Items.Add(url);
                }
            }

            if (policyList.SelectedItem != null)
            {
                Regex regex = new Regex(@"\w*");
                Match match = regex.Match(tenantTxt.Text);
                RunNowtxt.Text = string.Format("https://{0}.b2clogin.com/{1}/oauth2/v2.0/authorize?p={2}&client_id={3}&nonce=defaultNonce&redirect_uri={4}&scope=openid {5}&response_type=id_token token&prompt=login&disable_cache=true", match.Value, tenantTxt.Text, policyList.SelectedItem.ToString(), appId, replyUrl.SelectedItem, b2cResource.Text);
            }

            Properties.Settings.Default.ReplyUrl = replyUrl.SelectedItem.ToString();
            Properties.Settings.Default.Save();
        }
    }
}
