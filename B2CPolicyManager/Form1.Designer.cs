namespace B2CPolicyManager
{
    partial class B2CPolicyManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(B2CPolicyManager));
            this.selectPolicyBtn = new System.Windows.Forms.Button();
            this.policyFolderLbl = new System.Windows.Forms.Label();
            this.listBtn = new System.Windows.Forms.Button();
            this.deleteSelectedBtn = new System.Windows.Forms.Button();
            this.policyList = new System.Windows.Forms.ListBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.UpdateAllPolicesBtn = new System.Windows.Forms.Button();
            this.checkedPolicyList = new System.Windows.Forms.CheckedListBox();
            this.RefrshFileListBtn = new System.Windows.Forms.Button();
            this.HTTPResponse = new System.Windows.Forms.TextBox();
            this.RunNowtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tenantTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.v2AppIDGraphtxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.VSCodeBtn = new System.Windows.Forms.Button();
            this.ChromeBtn = new System.Windows.Forms.Button();
            this.IEBtn = new System.Windows.Forms.Button();
            this.selectAllPolicies = new System.Windows.Forms.Button();
            this.deselectAllPolicies = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.showRPs = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.b2cResource = new System.Windows.Forms.TextBox();
            this.getAccessToken = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.policyListFilter = new System.Windows.Forms.TextBox();
            this.appList = new System.Windows.Forms.ComboBox();
            this.replyUrl = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectPolicyBtn
            // 
            this.selectPolicyBtn.Location = new System.Drawing.Point(46, 101);
            this.selectPolicyBtn.Name = "selectPolicyBtn";
            this.selectPolicyBtn.Size = new System.Drawing.Size(127, 23);
            this.selectPolicyBtn.TabIndex = 1;
            this.selectPolicyBtn.Text = "Select Policy Folder";
            this.selectPolicyBtn.UseVisualStyleBackColor = true;
            this.selectPolicyBtn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // policyFolderLbl
            // 
            this.policyFolderLbl.AutoSize = true;
            this.policyFolderLbl.Location = new System.Drawing.Point(49, 128);
            this.policyFolderLbl.Name = "policyFolderLbl";
            this.policyFolderLbl.Size = new System.Drawing.Size(99, 13);
            this.policyFolderLbl.TabIndex = 3;
            this.policyFolderLbl.Text = "No Folder selected.";
            this.policyFolderLbl.Click += new System.EventHandler(this.Label1_Click);
            // 
            // listBtn
            // 
            this.listBtn.Location = new System.Drawing.Point(275, 157);
            this.listBtn.Name = "listBtn";
            this.listBtn.Size = new System.Drawing.Size(97, 23);
            this.listBtn.TabIndex = 8;
            this.listBtn.Text = "List Policies";
            this.listBtn.UseVisualStyleBackColor = true;
            this.listBtn.Click += new System.EventHandler(this.ListBtn_ClickAsync);
            // 
            // deleteSelectedBtn
            // 
            this.deleteSelectedBtn.Location = new System.Drawing.Point(380, 397);
            this.deleteSelectedBtn.Name = "deleteSelectedBtn";
            this.deleteSelectedBtn.Size = new System.Drawing.Size(97, 23);
            this.deleteSelectedBtn.TabIndex = 9;
            this.deleteSelectedBtn.Text = "Delete Selected Policy";
            this.deleteSelectedBtn.UseVisualStyleBackColor = true;
            this.deleteSelectedBtn.Click += new System.EventHandler(this.DeleteSelectedBtn_Click);
            // 
            // policyList
            // 
            this.policyList.FormattingEnabled = true;
            this.policyList.Location = new System.Drawing.Point(275, 213);
            this.policyList.Name = "policyList";
            this.policyList.Size = new System.Drawing.Size(202, 173);
            this.policyList.TabIndex = 10;
            this.policyList.SelectedIndexChanged += new System.EventHandler(this.policyList_SelectedIndexChanged);
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(543, 34);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 0;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // UpdateAllPolicesBtn
            // 
            this.UpdateAllPolicesBtn.Location = new System.Drawing.Point(46, 184);
            this.UpdateAllPolicesBtn.Name = "UpdateAllPolicesBtn";
            this.UpdateAllPolicesBtn.Size = new System.Drawing.Size(202, 23);
            this.UpdateAllPolicesBtn.TabIndex = 5;
            this.UpdateAllPolicesBtn.Text = "Update Policies (PUT)";
            this.UpdateAllPolicesBtn.UseVisualStyleBackColor = true;
            this.UpdateAllPolicesBtn.Click += new System.EventHandler(this.UpdateAllPolicesBtn_Click);
            // 
            // checkedPolicyList
            // 
            this.checkedPolicyList.CheckOnClick = true;
            this.checkedPolicyList.FormattingEnabled = true;
            this.checkedPolicyList.HorizontalScrollbar = true;
            this.checkedPolicyList.Location = new System.Drawing.Point(46, 213);
            this.checkedPolicyList.Name = "checkedPolicyList";
            this.checkedPolicyList.Size = new System.Drawing.Size(202, 154);
            this.checkedPolicyList.TabIndex = 6;
            this.checkedPolicyList.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // RefrshFileListBtn
            // 
            this.RefrshFileListBtn.Location = new System.Drawing.Point(329, 101);
            this.RefrshFileListBtn.Name = "RefrshFileListBtn";
            this.RefrshFileListBtn.Size = new System.Drawing.Size(102, 23);
            this.RefrshFileListBtn.TabIndex = 7;
            this.RefrshFileListBtn.Text = "Refresh File List";
            this.RefrshFileListBtn.UseVisualStyleBackColor = true;
            this.RefrshFileListBtn.Click += new System.EventHandler(this.RefrshFileListBtn_Click);
            // 
            // HTTPResponse
            // 
            this.HTTPResponse.AccessibleDescription = "";
            this.HTTPResponse.Location = new System.Drawing.Point(46, 424);
            this.HTTPResponse.Multiline = true;
            this.HTTPResponse.Name = "HTTPResponse";
            this.HTTPResponse.ReadOnly = true;
            this.HTTPResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.HTTPResponse.Size = new System.Drawing.Size(753, 219);
            this.HTTPResponse.TabIndex = 25;
            // 
            // RunNowtxt
            // 
            this.RunNowtxt.Location = new System.Drawing.Point(506, 308);
            this.RunNowtxt.Multiline = true;
            this.RunNowtxt.Name = "RunNowtxt";
            this.RunNowtxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RunNowtxt.Size = new System.Drawing.Size(246, 82);
            this.RunNowtxt.TabIndex = 21;
            //this.RunNowtxt.TextChanged += new System.EventHandler(this.RunNowtxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(503, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "B2C Application Registration";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(503, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "ReplyUrl";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(504, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "OpenId Run Now Link";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(756, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Copy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tenantTxt
            // 
            this.tenantTxt.Location = new System.Drawing.Point(16, 37);
            this.tenantTxt.Name = "tenantTxt";
            this.tenantTxt.Size = new System.Drawing.Size(242, 20);
            this.tenantTxt.TabIndex = 13;
            this.tenantTxt.Text = "00000000-0000-0000-0000-000000000000";
            this.tenantTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "V1 Graph App Id";
            // 
            // v2AppIDGraphtxt
            // 
            this.v2AppIDGraphtxt.Location = new System.Drawing.Point(273, 37);
            this.v2AppIDGraphtxt.Name = "v2AppIDGraphtxt";
            this.v2AppIDGraphtxt.Size = new System.Drawing.Size(242, 20);
            this.v2AppIDGraphtxt.TabIndex = 15;
            this.v2AppIDGraphtxt.Text = "00000000-0000-0000-0000-000000000000";
            this.v2AppIDGraphtxt.TextChanged += new System.EventHandler(this.v2AppIDGraphtxt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tenant";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(724, 647);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "Clear Log";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // VSCodeBtn
            // 
            this.VSCodeBtn.Location = new System.Drawing.Point(179, 101);
            this.VSCodeBtn.Name = "VSCodeBtn";
            this.VSCodeBtn.Size = new System.Drawing.Size(144, 23);
            this.VSCodeBtn.TabIndex = 2;
            this.VSCodeBtn.Text = "Open Folder in VSCode";
            this.VSCodeBtn.UseVisualStyleBackColor = true;
            this.VSCodeBtn.Click += new System.EventHandler(this.VSCodeBtn_Click);
            // 
            // ChromeBtn
            // 
            this.ChromeBtn.Location = new System.Drawing.Point(507, 397);
            this.ChromeBtn.Name = "ChromeBtn";
            this.ChromeBtn.Size = new System.Drawing.Size(91, 23);
            this.ChromeBtn.TabIndex = 23;
            this.ChromeBtn.Text = "Open in Chrome";
            this.ChromeBtn.UseVisualStyleBackColor = true;
            this.ChromeBtn.Click += new System.EventHandler(this.EdgeBtn_Click);
            // 
            // IEBtn
            // 
            this.IEBtn.Location = new System.Drawing.Point(604, 397);
            this.IEBtn.Name = "IEBtn";
            this.IEBtn.Size = new System.Drawing.Size(91, 23);
            this.IEBtn.TabIndex = 24;
            this.IEBtn.Text = "Open in Edge";
            this.IEBtn.UseVisualStyleBackColor = true;
            this.IEBtn.Click += new System.EventHandler(this.IEBtn_Click);
            // 
            // selectAllPolicies
            // 
            this.selectAllPolicies.Location = new System.Drawing.Point(46, 397);
            this.selectAllPolicies.Margin = new System.Windows.Forms.Padding(2);
            this.selectAllPolicies.Name = "selectAllPolicies";
            this.selectAllPolicies.Size = new System.Drawing.Size(85, 23);
            this.selectAllPolicies.TabIndex = 30;
            this.selectAllPolicies.Text = "Select All";
            this.selectAllPolicies.UseVisualStyleBackColor = true;
            this.selectAllPolicies.Click += new System.EventHandler(this.button6_Click);
            // 
            // deselectAllPolicies
            // 
            this.deselectAllPolicies.Location = new System.Drawing.Point(134, 397);
            this.deselectAllPolicies.Margin = new System.Windows.Forms.Padding(2);
            this.deselectAllPolicies.Name = "deselectAllPolicies";
            this.deselectAllPolicies.Size = new System.Drawing.Size(85, 23);
            this.deselectAllPolicies.TabIndex = 31;
            this.deselectAllPolicies.Text = "Deselect All";
            this.deselectAllPolicies.UseVisualStyleBackColor = true;
            this.deselectAllPolicies.Click += new System.EventHandler(this.deselectAllPolicies_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(701, 397);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(91, 23);
            this.button6.TabIndex = 32;
            this.button6.Text = "Saml SP";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // showRPs
            // 
            this.showRPs.AutoSize = true;
            this.showRPs.Location = new System.Drawing.Point(275, 401);
            this.showRPs.Margin = new System.Windows.Forms.Padding(2);
            this.showRPs.Name = "showRPs";
            this.showRPs.Size = new System.Drawing.Size(98, 17);
            this.showRPs.TabIndex = 34;
            this.showRPs.Text = "Only show RPs";
            this.showRPs.UseVisualStyleBackColor = true;
            this.showRPs.CheckedChanged += new System.EventHandler(this.showRPs_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(503, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "B2C Resource";
            // 
            // b2cResource
            // 
            this.b2cResource.Location = new System.Drawing.Point(506, 239);
            this.b2cResource.Name = "b2cResource";
            this.b2cResource.Size = new System.Drawing.Size(295, 20);
            this.b2cResource.TabIndex = 36;
            this.b2cResource.TextChanged += new System.EventHandler(this.b2cResource_TextChanged);
            // 
            // getAccessToken
            // 
            this.getAccessToken.AutoSize = true;
            this.getAccessToken.Location = new System.Drawing.Point(507, 260);
            this.getAccessToken.Margin = new System.Windows.Forms.Padding(2);
            this.getAccessToken.Name = "getAccessToken";
            this.getAccessToken.Size = new System.Drawing.Size(115, 17);
            this.getAccessToken.TabIndex = 37;
            this.getAccessToken.Text = "Get Access Token";
            this.getAccessToken.UseVisualStyleBackColor = true;
            this.getAccessToken.CheckedChanged += new System.EventHandler(this.getAccessToken_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tenantTxt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.v2AppIDGraphtxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.loginBtn);
            this.groupBox1.Location = new System.Drawing.Point(46, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(649, 73);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Authenticate to Graph API";
            // 
            // policyListFilter
            // 
            this.policyListFilter.Location = new System.Drawing.Point(275, 186);
            this.policyListFilter.Name = "policyListFilter";
            this.policyListFilter.Size = new System.Drawing.Size(202, 20);
            this.policyListFilter.TabIndex = 39;
            this.policyListFilter.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // appList
            // 
            this.appList.FormattingEnabled = true;
            this.appList.Location = new System.Drawing.Point(507, 151);
            this.appList.Name = "appList";
            this.appList.Size = new System.Drawing.Size(294, 21);
            this.appList.TabIndex = 40;
            this.appList.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // replyUrl
            // 
            this.replyUrl.FormattingEnabled = true;
            this.replyUrl.Location = new System.Drawing.Point(507, 195);
            this.replyUrl.Name = "replyUrl";
            this.replyUrl.Size = new System.Drawing.Size(294, 21);
            this.replyUrl.TabIndex = 41;
            this.replyUrl.SelectedIndexChanged += new System.EventHandler(this.replyUrl_SelectedIndexChanged);
            // 
            // B2CPolicyManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(847, 716);
            this.Controls.Add(this.replyUrl);
            this.Controls.Add(this.appList);
            this.Controls.Add(this.policyListFilter);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.getAccessToken);
            this.Controls.Add(this.b2cResource);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.showRPs);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.deselectAllPolicies);
            this.Controls.Add(this.selectAllPolicies);
            this.Controls.Add(this.IEBtn);
            this.Controls.Add(this.ChromeBtn);
            this.Controls.Add(this.VSCodeBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RunNowtxt);
            this.Controls.Add(this.HTTPResponse);
            this.Controls.Add(this.RefrshFileListBtn);
            this.Controls.Add(this.checkedPolicyList);
            this.Controls.Add(this.UpdateAllPolicesBtn);
            this.Controls.Add(this.policyList);
            this.Controls.Add(this.deleteSelectedBtn);
            this.Controls.Add(this.listBtn);
            this.Controls.Add(this.policyFolderLbl);
            this.Controls.Add(this.selectPolicyBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(863, 755);
            this.MinimumSize = new System.Drawing.Size(863, 755);
            this.Name = "B2CPolicyManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AAD B2C Custom Policy Manager";
            this.Load += new System.EventHandler(this.B2CPolicyManager_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectPolicyBtn;
        private System.Windows.Forms.Label policyFolderLbl;
        private System.Windows.Forms.Button listBtn;
        private System.Windows.Forms.Button deleteSelectedBtn;
        private System.Windows.Forms.ListBox policyList;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button UpdateAllPolicesBtn;
        private System.Windows.Forms.CheckedListBox checkedPolicyList;
        private System.Windows.Forms.Button RefrshFileListBtn;
        private System.Windows.Forms.TextBox HTTPResponse;
        private System.Windows.Forms.TextBox RunNowtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tenantTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox v2AppIDGraphtxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button VSCodeBtn;
        private System.Windows.Forms.Button ChromeBtn;
        private System.Windows.Forms.Button IEBtn;
        private System.Windows.Forms.Button selectAllPolicies;
        private System.Windows.Forms.Button deselectAllPolicies;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.CheckBox showRPs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox b2cResource;
        private System.Windows.Forms.CheckBox getAccessToken;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox policyListFilter;
        private System.Windows.Forms.ComboBox appList;
        private System.Windows.Forms.ComboBox replyUrl;
    }
}

