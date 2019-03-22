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
            this.deleteAllBtn = new System.Windows.Forms.Button();
            this.policyList = new System.Windows.Forms.ListBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.UpdateAllPolicesBtn = new System.Windows.Forms.Button();
            this.checkedPolicyList = new System.Windows.Forms.CheckedListBox();
            this.RefrshFileListBtn = new System.Windows.Forms.Button();
            this.HTTPResponse = new System.Windows.Forms.TextBox();
            this.AppIdtxt = new System.Windows.Forms.TextBox();
            this.ReplyUrltxt = new System.Windows.Forms.TextBox();
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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectPolicyBtn
            // 
            this.selectPolicyBtn.Location = new System.Drawing.Point(84, 187);
            this.selectPolicyBtn.Margin = new System.Windows.Forms.Padding(6);
            this.selectPolicyBtn.Name = "selectPolicyBtn";
            this.selectPolicyBtn.Size = new System.Drawing.Size(233, 42);
            this.selectPolicyBtn.TabIndex = 1;
            this.selectPolicyBtn.Text = "Select Policy Folder";
            this.selectPolicyBtn.UseVisualStyleBackColor = true;
            this.selectPolicyBtn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // policyFolderLbl
            // 
            this.policyFolderLbl.AutoSize = true;
            this.policyFolderLbl.Location = new System.Drawing.Point(90, 237);
            this.policyFolderLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.policyFolderLbl.Name = "policyFolderLbl";
            this.policyFolderLbl.Size = new System.Drawing.Size(180, 25);
            this.policyFolderLbl.TabIndex = 3;
            this.policyFolderLbl.Text = "No Folder selected.";
            this.policyFolderLbl.Click += new System.EventHandler(this.Label1_Click);
            // 
            // listBtn
            // 
            this.listBtn.Location = new System.Drawing.Point(504, 340);
            this.listBtn.Margin = new System.Windows.Forms.Padding(6);
            this.listBtn.Name = "listBtn";
            this.listBtn.Size = new System.Drawing.Size(178, 42);
            this.listBtn.TabIndex = 8;
            this.listBtn.Text = "List Policies";
            this.listBtn.UseVisualStyleBackColor = true;
            this.listBtn.Click += new System.EventHandler(this.ListBtn_ClickAsync);
            // 
            // deleteSelectedBtn
            // 
            this.deleteSelectedBtn.Location = new System.Drawing.Point(697, 340);
            this.deleteSelectedBtn.Margin = new System.Windows.Forms.Padding(6);
            this.deleteSelectedBtn.Name = "deleteSelectedBtn";
            this.deleteSelectedBtn.Size = new System.Drawing.Size(178, 42);
            this.deleteSelectedBtn.TabIndex = 9;
            this.deleteSelectedBtn.Text = "Delete Selected Policy";
            this.deleteSelectedBtn.UseVisualStyleBackColor = true;
            this.deleteSelectedBtn.Click += new System.EventHandler(this.DeleteSelectedBtn_Click);
            // 
            // deleteAllBtn
            // 
            this.deleteAllBtn.Location = new System.Drawing.Point(504, 730);
            this.deleteAllBtn.Margin = new System.Windows.Forms.Padding(6);
            this.deleteAllBtn.Name = "deleteAllBtn";
            this.deleteAllBtn.Size = new System.Drawing.Size(233, 42);
            this.deleteAllBtn.TabIndex = 11;
            this.deleteAllBtn.Text = "Delete All Policies";
            this.deleteAllBtn.UseVisualStyleBackColor = true;
            this.deleteAllBtn.Click += new System.EventHandler(this.DeleteAllBtn_Click);
            // 
            // policyList
            // 
            this.policyList.FormattingEnabled = true;
            this.policyList.ItemHeight = 24;
            this.policyList.Location = new System.Drawing.Point(504, 394);
            this.policyList.Margin = new System.Windows.Forms.Padding(6);
            this.policyList.Name = "policyList";
            this.policyList.Size = new System.Drawing.Size(367, 316);
            this.policyList.TabIndex = 10;
            this.policyList.SelectedIndexChanged += new System.EventHandler(this.policyList_SelectedIndexChanged);
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(996, 63);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(6);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(138, 42);
            this.loginBtn.TabIndex = 0;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // UpdateAllPolicesBtn
            // 
            this.UpdateAllPolicesBtn.Location = new System.Drawing.Point(84, 340);
            this.UpdateAllPolicesBtn.Margin = new System.Windows.Forms.Padding(6);
            this.UpdateAllPolicesBtn.Name = "UpdateAllPolicesBtn";
            this.UpdateAllPolicesBtn.Size = new System.Drawing.Size(370, 42);
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
            this.checkedPolicyList.Location = new System.Drawing.Point(84, 394);
            this.checkedPolicyList.Margin = new System.Windows.Forms.Padding(6);
            this.checkedPolicyList.Name = "checkedPolicyList";
            this.checkedPolicyList.Size = new System.Drawing.Size(367, 292);
            this.checkedPolicyList.TabIndex = 6;
            this.checkedPolicyList.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // RefrshFileListBtn
            // 
            this.RefrshFileListBtn.Location = new System.Drawing.Point(603, 187);
            this.RefrshFileListBtn.Margin = new System.Windows.Forms.Padding(6);
            this.RefrshFileListBtn.Name = "RefrshFileListBtn";
            this.RefrshFileListBtn.Size = new System.Drawing.Size(187, 42);
            this.RefrshFileListBtn.TabIndex = 7;
            this.RefrshFileListBtn.Text = "Refresh File List";
            this.RefrshFileListBtn.UseVisualStyleBackColor = true;
            this.RefrshFileListBtn.Click += new System.EventHandler(this.RefrshFileListBtn_Click);
            // 
            // HTTPResponse
            // 
            this.HTTPResponse.AccessibleDescription = "";
            this.HTTPResponse.Location = new System.Drawing.Point(84, 783);
            this.HTTPResponse.Margin = new System.Windows.Forms.Padding(6);
            this.HTTPResponse.Multiline = true;
            this.HTTPResponse.Name = "HTTPResponse";
            this.HTTPResponse.ReadOnly = true;
            this.HTTPResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.HTTPResponse.Size = new System.Drawing.Size(1377, 401);
            this.HTTPResponse.TabIndex = 25;
            // 
            // AppIdtxt
            // 
            this.AppIdtxt.Location = new System.Drawing.Point(928, 281);
            this.AppIdtxt.Margin = new System.Windows.Forms.Padding(6);
            this.AppIdtxt.Name = "AppIdtxt";
            this.AppIdtxt.Size = new System.Drawing.Size(538, 29);
            this.AppIdtxt.TabIndex = 17;
            this.AppIdtxt.Text = "00000000-0000-0000-0000-000000000000";
            this.AppIdtxt.TextChanged += new System.EventHandler(this.AppIdtxt_TextChanged_1);
            // 
            // ReplyUrltxt
            // 
            this.ReplyUrltxt.Location = new System.Drawing.Point(928, 360);
            this.ReplyUrltxt.Margin = new System.Windows.Forms.Padding(6);
            this.ReplyUrltxt.Name = "ReplyUrltxt";
            this.ReplyUrltxt.Size = new System.Drawing.Size(538, 29);
            this.ReplyUrltxt.TabIndex = 19;
            this.ReplyUrltxt.Text = "https://jwt.ms";
            this.ReplyUrltxt.TextChanged += new System.EventHandler(this.ReplyUrltxt_TextChanged);
            // 
            // RunNowtxt
            // 
            this.RunNowtxt.Location = new System.Drawing.Point(928, 569);
            this.RunNowtxt.Margin = new System.Windows.Forms.Padding(6);
            this.RunNowtxt.Multiline = true;
            this.RunNowtxt.Name = "RunNowtxt";
            this.RunNowtxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RunNowtxt.Size = new System.Drawing.Size(448, 148);
            this.RunNowtxt.TabIndex = 21;
            this.RunNowtxt.TextChanged += new System.EventHandler(this.RunNowtxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(923, 250);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "B2C ApplicationId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(923, 329);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "ReplyUrl";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(924, 540);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "OpenId Run Now Link";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1386, 569);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 42);
            this.button1.TabIndex = 22;
            this.button1.Text = "Copy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tenantTxt
            // 
            this.tenantTxt.Location = new System.Drawing.Point(30, 69);
            this.tenantTxt.Margin = new System.Windows.Forms.Padding(6);
            this.tenantTxt.Name = "tenantTxt";
            this.tenantTxt.Size = new System.Drawing.Size(441, 29);
            this.tenantTxt.TabIndex = 13;
            this.tenantTxt.Text = "00000000-0000-0000-0000-000000000000";
            this.tenantTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(495, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "V1 Graph App Id";
            // 
            // v2AppIDGraphtxt
            // 
            this.v2AppIDGraphtxt.Location = new System.Drawing.Point(500, 69);
            this.v2AppIDGraphtxt.Margin = new System.Windows.Forms.Padding(6);
            this.v2AppIDGraphtxt.Name = "v2AppIDGraphtxt";
            this.v2AppIDGraphtxt.Size = new System.Drawing.Size(441, 29);
            this.v2AppIDGraphtxt.TabIndex = 15;
            this.v2AppIDGraphtxt.Text = "00000000-0000-0000-0000-000000000000";
            this.v2AppIDGraphtxt.TextChanged += new System.EventHandler(this.v2AppIDGraphtxt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tenant";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1327, 1195);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 42);
            this.button2.TabIndex = 26;
            this.button2.Text = "Clear Log";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // VSCodeBtn
            // 
            this.VSCodeBtn.Location = new System.Drawing.Point(328, 187);
            this.VSCodeBtn.Margin = new System.Windows.Forms.Padding(6);
            this.VSCodeBtn.Name = "VSCodeBtn";
            this.VSCodeBtn.Size = new System.Drawing.Size(264, 42);
            this.VSCodeBtn.TabIndex = 2;
            this.VSCodeBtn.Text = "Open Folder in VSCode";
            this.VSCodeBtn.UseVisualStyleBackColor = true;
            this.VSCodeBtn.Click += new System.EventHandler(this.VSCodeBtn_Click);
            // 
            // ChromeBtn
            // 
            this.ChromeBtn.Location = new System.Drawing.Point(930, 732);
            this.ChromeBtn.Margin = new System.Windows.Forms.Padding(6);
            this.ChromeBtn.Name = "ChromeBtn";
            this.ChromeBtn.Size = new System.Drawing.Size(167, 42);
            this.ChromeBtn.TabIndex = 23;
            this.ChromeBtn.Text = "Open in Chrome";
            this.ChromeBtn.UseVisualStyleBackColor = true;
            this.ChromeBtn.Click += new System.EventHandler(this.EdgeBtn_Click);
            // 
            // IEBtn
            // 
            this.IEBtn.Location = new System.Drawing.Point(1107, 732);
            this.IEBtn.Margin = new System.Windows.Forms.Padding(6);
            this.IEBtn.Name = "IEBtn";
            this.IEBtn.Size = new System.Drawing.Size(167, 42);
            this.IEBtn.TabIndex = 24;
            this.IEBtn.Text = "Open in IE";
            this.IEBtn.UseVisualStyleBackColor = true;
            this.IEBtn.Click += new System.EventHandler(this.IEBtn_Click);
            // 
            // selectAllPolicies
            // 
            this.selectAllPolicies.Location = new System.Drawing.Point(84, 732);
            this.selectAllPolicies.Margin = new System.Windows.Forms.Padding(4);
            this.selectAllPolicies.Name = "selectAllPolicies";
            this.selectAllPolicies.Size = new System.Drawing.Size(156, 42);
            this.selectAllPolicies.TabIndex = 30;
            this.selectAllPolicies.Text = "Select All";
            this.selectAllPolicies.UseVisualStyleBackColor = true;
            this.selectAllPolicies.Click += new System.EventHandler(this.button6_Click);
            // 
            // deselectAllPolicies
            // 
            this.deselectAllPolicies.Location = new System.Drawing.Point(246, 732);
            this.deselectAllPolicies.Margin = new System.Windows.Forms.Padding(4);
            this.deselectAllPolicies.Name = "deselectAllPolicies";
            this.deselectAllPolicies.Size = new System.Drawing.Size(156, 42);
            this.deselectAllPolicies.TabIndex = 31;
            this.deselectAllPolicies.Text = "Deselect All";
            this.deselectAllPolicies.UseVisualStyleBackColor = true;
            this.deselectAllPolicies.Click += new System.EventHandler(this.deselectAllPolicies_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1285, 732);
            this.button6.Margin = new System.Windows.Forms.Padding(6);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(167, 42);
            this.button6.TabIndex = 32;
            this.button6.Text = "Saml SP";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // showRPs
            // 
            this.showRPs.AutoSize = true;
            this.showRPs.Location = new System.Drawing.Point(504, 292);
            this.showRPs.Name = "showRPs";
            this.showRPs.Size = new System.Drawing.Size(171, 29);
            this.showRPs.TabIndex = 34;
            this.showRPs.Text = "Only show RPs";
            this.showRPs.UseVisualStyleBackColor = true;
            this.showRPs.CheckedChanged += new System.EventHandler(this.showRPs_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(923, 410);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 25);
            this.label6.TabIndex = 35;
            this.label6.Text = "B2C Resource";
            // 
            // b2cResource
            // 
            this.b2cResource.Location = new System.Drawing.Point(928, 441);
            this.b2cResource.Margin = new System.Windows.Forms.Padding(6);
            this.b2cResource.Name = "b2cResource";
            this.b2cResource.Size = new System.Drawing.Size(538, 29);
            this.b2cResource.TabIndex = 36;
            this.b2cResource.TextChanged += new System.EventHandler(this.b2cResource_TextChanged);
            // 
            // getAccessToken
            // 
            this.getAccessToken.AutoSize = true;
            this.getAccessToken.Location = new System.Drawing.Point(930, 480);
            this.getAccessToken.Name = "getAccessToken";
            this.getAccessToken.Size = new System.Drawing.Size(200, 29);
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
            this.groupBox1.Location = new System.Drawing.Point(84, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1190, 134);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Authenticate to Graph API";
            // 
            // B2CPolicyManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1544, 1297);
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
            this.Controls.Add(this.ReplyUrltxt);
            this.Controls.Add(this.AppIdtxt);
            this.Controls.Add(this.HTTPResponse);
            this.Controls.Add(this.RefrshFileListBtn);
            this.Controls.Add(this.checkedPolicyList);
            this.Controls.Add(this.UpdateAllPolicesBtn);
            this.Controls.Add(this.policyList);
            this.Controls.Add(this.deleteAllBtn);
            this.Controls.Add(this.deleteSelectedBtn);
            this.Controls.Add(this.listBtn);
            this.Controls.Add(this.policyFolderLbl);
            this.Controls.Add(this.selectPolicyBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(1568, 1361);
            this.MinimumSize = new System.Drawing.Size(1568, 1361);
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
        private System.Windows.Forms.Button deleteAllBtn;
        private System.Windows.Forms.ListBox policyList;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button UpdateAllPolicesBtn;
        private System.Windows.Forms.CheckedListBox checkedPolicyList;
        private System.Windows.Forms.Button RefrshFileListBtn;
        private System.Windows.Forms.TextBox HTTPResponse;
        private System.Windows.Forms.TextBox AppIdtxt;
        private System.Windows.Forms.TextBox ReplyUrltxt;
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
    }
}

