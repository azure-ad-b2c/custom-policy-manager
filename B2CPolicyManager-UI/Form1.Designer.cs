namespace B2CPolicyManagerUI
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
			btnSelectPolicyFolder = new System.Windows.Forms.Button();
			policyFolderLbl = new System.Windows.Forms.Label();
			btnListPolicies = new System.Windows.Forms.Button();
			btnFetchPolicies = new System.Windows.Forms.Button();
			btnDeleteSelected = new System.Windows.Forms.Button();
			lstPolicies = new System.Windows.Forms.ListBox();
			btnLogin = new System.Windows.Forms.Button();
			btnUpdateSelectedPolices = new System.Windows.Forms.Button();
			lstPolicyFiles = new System.Windows.Forms.CheckedListBox();
			btnRefrshFileList = new System.Windows.Forms.Button();
			HTTPResponse = new System.Windows.Forms.TextBox();
			txtRunNow = new System.Windows.Forms.TextBox();
			label1 = new System.Windows.Forms.Label();
			label2 = new System.Windows.Forms.Label();
			label3 = new System.Windows.Forms.Label();
			btnCopyRunNow = new System.Windows.Forms.Button();
			tenantTxt = new System.Windows.Forms.TextBox();
			label4 = new System.Windows.Forms.Label();
			txtAppId = new System.Windows.Forms.TextBox();
			label5 = new System.Windows.Forms.Label();
			btnClearLog = new System.Windows.Forms.Button();
			chkVerbose = new System.Windows.Forms.CheckBox();
			btnOpenFolderInVSCode = new System.Windows.Forms.Button();
			btnOpenInChrome = new System.Windows.Forms.Button();
			btnOpenInEdge = new System.Windows.Forms.Button();
			btnSelectAllPolicies = new System.Windows.Forms.Button();
			btnDeselectAllPolicies = new System.Windows.Forms.Button();
			btnSamlSP = new System.Windows.Forms.Button();
			showRPs = new System.Windows.Forms.CheckBox();
			label6 = new System.Windows.Forms.Label();
			b2cResource = new System.Windows.Forms.TextBox();
			getAccessToken = new System.Windows.Forms.CheckBox();
			groupBox1 = new System.Windows.Forms.GroupBox();
			txtPoliciesFilter = new System.Windows.Forms.TextBox();
			lstAppRegistrations = new System.Windows.Forms.ComboBox();
			txtReplyUrl = new System.Windows.Forms.ComboBox();
			txtPolicyFileFilter = new System.Windows.Forms.TextBox();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// btnSelectPolicyFolder
			// 
			btnSelectPolicyFolder.Location = new System.Drawing.Point( 100, 248 );
			btnSelectPolicyFolder.Margin = new System.Windows.Forms.Padding( 6, 8, 6, 8 );
			btnSelectPolicyFolder.Name = "btnSelectPolicyFolder";
			btnSelectPolicyFolder.Size = new System.Drawing.Size( 275, 56 );
			btnSelectPolicyFolder.TabIndex = 1;
			btnSelectPolicyFolder.Text = "Select Policy Folder";
			btnSelectPolicyFolder.UseVisualStyleBackColor = true;
			btnSelectPolicyFolder.Click +=  btnSelectPolicyFolder_Click ;
			// 
			// policyFolderLbl
			// 
			policyFolderLbl.AutoSize = true;
			policyFolderLbl.Location = new System.Drawing.Point( 106, 315 );
			policyFolderLbl.Margin = new System.Windows.Forms.Padding( 6, 0, 6, 0 );
			policyFolderLbl.Name = "policyFolderLbl";
			policyFolderLbl.Size = new System.Drawing.Size( 220, 32 );
			policyFolderLbl.TabIndex = 3;
			policyFolderLbl.Text = "No Folder selected.";
			// 
			// btnListPolicies
			// 
			btnListPolicies.Location = new System.Drawing.Point( 596, 387 );
			btnListPolicies.Margin = new System.Windows.Forms.Padding( 6, 8, 6, 8 );
			btnListPolicies.Name = "btnListPolicies";
			btnListPolicies.Size = new System.Drawing.Size( 210, 56 );
			btnListPolicies.TabIndex = 8;
			btnListPolicies.Text = "List Policies";
			btnListPolicies.UseVisualStyleBackColor = true;
			btnListPolicies.Click +=  btnListPolicies_Click ;
			//
			// btnFetchPolicies
			//
			btnFetchPolicies.Location = new System.Drawing.Point( 818, 387 );
			btnFetchPolicies.Margin = new System.Windows.Forms.Padding( 6, 8, 6, 8 );
			btnFetchPolicies.Name = "btnFetchPolicies";
			btnFetchPolicies.Size = new System.Drawing.Size( 211, 56 );
			btnFetchPolicies.TabIndex = 43;
			btnFetchPolicies.Text = "Fetch Policies";
			btnFetchPolicies.UseVisualStyleBackColor = true;
			btnFetchPolicies.Click +=  btnFetchPolicies_Click ;
			//
			// btnDeleteSelected
			//
			btnDeleteSelected.Location = new System.Drawing.Point( 823, 977 );
			btnDeleteSelected.Margin = new System.Windows.Forms.Padding( 6, 8, 6, 8 );
			btnDeleteSelected.Name = "btnDeleteSelected";
			btnDeleteSelected.Size = new System.Drawing.Size( 210, 56 );
			btnDeleteSelected.TabIndex = 9;
			btnDeleteSelected.Text = "Delete Selected Policy";
			btnDeleteSelected.UseVisualStyleBackColor = true;
			btnDeleteSelected.Click +=  btnDeleteSelected_Click ;
			// 
			// lstPolicies
			// 
			lstPolicies.FormattingEnabled = true;
			lstPolicies.Location = new System.Drawing.Point( 596, 525 );
			lstPolicies.Margin = new System.Windows.Forms.Padding( 6, 8, 6, 8 );
			lstPolicies.Name = "lstPolicies";
			lstPolicies.Size = new System.Drawing.Size( 433, 420 );
			lstPolicies.TabIndex = 10;
			lstPolicies.SelectedIndexChanged +=  lstPolicies_SelectedIndexChanged ;
			// 
			// btnLogin
			// 
			btnLogin.Location = new System.Drawing.Point( 1176, 83 );
			btnLogin.Margin = new System.Windows.Forms.Padding( 6, 8, 6, 8 );
			btnLogin.Name = "btnLogin";
			btnLogin.Size = new System.Drawing.Size( 162, 56 );
			btnLogin.TabIndex = 0;
			btnLogin.Text = "Login";
			btnLogin.UseVisualStyleBackColor = true;
			btnLogin.Click +=  btnLogin_Click ;
			// 
			// btnUpdateSelectedPolices
			// 
			btnUpdateSelectedPolices.Location = new System.Drawing.Point( 100, 387 );
			btnUpdateSelectedPolices.Margin = new System.Windows.Forms.Padding( 6, 8, 6, 8 );
			btnUpdateSelectedPolices.Name = "btnUpdateSelectedPolices";
			btnUpdateSelectedPolices.Size = new System.Drawing.Size( 275, 56 );
			btnUpdateSelectedPolices.TabIndex = 5;
			btnUpdateSelectedPolices.Text = "Update Policies (PUT)";
			btnUpdateSelectedPolices.UseVisualStyleBackColor = true;
			btnUpdateSelectedPolices.Click +=  btnUpdateSelectedPolices_Click ;
			// 
			// lstPolicyFiles
			// 
			lstPolicyFiles.CheckOnClick = true;
			lstPolicyFiles.FormattingEnabled = true;
			lstPolicyFiles.HorizontalScrollbar = true;
			lstPolicyFiles.Location = new System.Drawing.Point( 100, 525 );
			lstPolicyFiles.Margin = new System.Windows.Forms.Padding( 6, 8, 6, 8 );
			lstPolicyFiles.Name = "lstPolicyFiles";
			lstPolicyFiles.Size = new System.Drawing.Size( 433, 436 );
			lstPolicyFiles.TabIndex = 6;
			// 
			// btnRefrshFileList
			// 
			btnRefrshFileList.Location = new System.Drawing.Point( 713, 248 );
			btnRefrshFileList.Margin = new System.Windows.Forms.Padding( 6, 8, 6, 8 );
			btnRefrshFileList.Name = "btnRefrshFileList";
			btnRefrshFileList.Size = new System.Drawing.Size( 221, 56 );
			btnRefrshFileList.TabIndex = 7;
			btnRefrshFileList.Text = "Refresh File List";
			btnRefrshFileList.UseVisualStyleBackColor = true;
			btnRefrshFileList.Click +=  btnRefrshFileList_Click ;
			// 
			// HTTPResponse
			// 
			HTTPResponse.AccessibleDescription = "";
			HTTPResponse.Location = new System.Drawing.Point( 100, 1043 );
			HTTPResponse.Margin = new System.Windows.Forms.Padding( 6, 8, 6, 8 );
			HTTPResponse.Multiline = true;
			HTTPResponse.Name = "HTTPResponse";
			HTTPResponse.ReadOnly = true;
			HTTPResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			HTTPResponse.Size = new System.Drawing.Size( 1627, 533 );
			HTTPResponse.TabIndex = 25;
			// 
			// txtRunNow
			// 
			txtRunNow.Location = new System.Drawing.Point( 1096, 758 );
			txtRunNow.Margin = new System.Windows.Forms.Padding( 6, 8, 6, 8 );
			txtRunNow.Multiline = true;
			txtRunNow.Name = "txtRunNow";
			txtRunNow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			txtRunNow.Size = new System.Drawing.Size( 528, 196 );
			txtRunNow.TabIndex = 21;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point( 1090, 333 );
			label1.Margin = new System.Windows.Forms.Padding( 6, 0, 6, 0 );
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size( 316, 32 );
			label1.TabIndex = 16;
			label1.Text = "B2C Application Registration";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point( 1090, 438 );
			label2.Margin = new System.Windows.Forms.Padding( 6, 0, 6, 0 );
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size( 102, 32 );
			label2.TabIndex = 18;
			label2.Text = "ReplyUrl";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new System.Drawing.Point( 1092, 721 );
			label3.Margin = new System.Windows.Forms.Padding( 6, 0, 6, 0 );
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size( 248, 32 );
			label3.TabIndex = 20;
			label3.Text = "OpenId Run Now Link";
			// 
			// btnCopyRunNow
			// 
			btnCopyRunNow.Location = new System.Drawing.Point( 1638, 758 );
			btnCopyRunNow.Margin = new System.Windows.Forms.Padding( 6, 8, 6, 8 );
			btnCopyRunNow.Name = "btnCopyRunNow";
			btnCopyRunNow.Size = new System.Drawing.Size( 93, 56 );
			btnCopyRunNow.TabIndex = 22;
			btnCopyRunNow.Text = "Copy";
			btnCopyRunNow.UseVisualStyleBackColor = true;
			btnCopyRunNow.Click +=  btnCopyRunNow_Click ;
			// 
			// tenantTxt
			// 
			tenantTxt.Location = new System.Drawing.Point( 35, 91 );
			tenantTxt.Margin = new System.Windows.Forms.Padding( 6, 8, 6, 8 );
			tenantTxt.Name = "tenantTxt";
			tenantTxt.Size = new System.Drawing.Size( 520, 39 );
			tenantTxt.TabIndex = 13;
			tenantTxt.Text = "<yourtenant>.onmicrosoft.com";
			tenantTxt.TextChanged +=  tenantTxt_TextChanged ;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new System.Drawing.Point( 585, 51 );
			label4.Margin = new System.Windows.Forms.Padding( 6, 0, 6, 0 );
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size( 190, 32 );
			label4.TabIndex = 14;
			label4.Text = "V2 Graph App Id";
			// 
			// txtAppId
			// 
			txtAppId.Location = new System.Drawing.Point( 592, 91 );
			txtAppId.Margin = new System.Windows.Forms.Padding( 6, 8, 6, 8 );
			txtAppId.Name = "txtAppId";
			txtAppId.Size = new System.Drawing.Size( 520, 39 );
			txtAppId.TabIndex = 15;
			txtAppId.Text = "00000000-0000-0000-0000-000000000000";
			txtAppId.TextChanged +=  txtAppId_TextChanged ;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new System.Drawing.Point( 30, 51 );
			label5.Margin = new System.Windows.Forms.Padding( 6, 0, 6, 0 );
			label5.Name = "label5";
			label5.Size = new System.Drawing.Size( 86, 32 );
			label5.TabIndex = 12;
			label5.Text = "Tenant";
			// 
			// btnClearLog
			// 
			btnClearLog.Location = new System.Drawing.Point( 1569, 1592 );
			btnClearLog.Margin = new System.Windows.Forms.Padding( 6, 8, 6, 8 );
			btnClearLog.Name = "btnClearLog";
			btnClearLog.Size = new System.Drawing.Size( 162, 56 );
			btnClearLog.TabIndex = 26;
			btnClearLog.Text = "Clear Log";
			btnClearLog.UseVisualStyleBackColor = true;
			btnClearLog.Click +=  btnClearLog_Click ;
			//
			// chkVerbose
			//
			chkVerbose.AutoSize = true;
			chkVerbose.Location = new System.Drawing.Point( 100, 1602 );
			chkVerbose.Margin = new System.Windows.Forms.Padding( 4, 5, 4, 5 );
			chkVerbose.Name = "chkVerbose";
			chkVerbose.Size = new System.Drawing.Size( 175, 36 );
			chkVerbose.TabIndex = 35;
			chkVerbose.Text = "Verbose log";
			chkVerbose.UseVisualStyleBackColor = true;
			chkVerbose.CheckedChanged +=  chkVerbose_CheckedChanged ;
			// 
			// btnOpenFolderInVSCode
			// 
			btnOpenFolderInVSCode.Location = new System.Drawing.Point( 388, 248 );
			btnOpenFolderInVSCode.Margin = new System.Windows.Forms.Padding( 6, 8, 6, 8 );
			btnOpenFolderInVSCode.Name = "btnOpenFolderInVSCode";
			btnOpenFolderInVSCode.Size = new System.Drawing.Size( 312, 56 );
			btnOpenFolderInVSCode.TabIndex = 2;
			btnOpenFolderInVSCode.Text = "Open Folder in VSCode";
			btnOpenFolderInVSCode.UseVisualStyleBackColor = true;
			btnOpenFolderInVSCode.Click +=  btnOpenFolderInVSCode_Click ;
			// 
			// btnOpenInChrome
			// 
			btnOpenInChrome.Location = new System.Drawing.Point( 1098, 977 );
			btnOpenInChrome.Margin = new System.Windows.Forms.Padding( 6, 8, 6, 8 );
			btnOpenInChrome.Name = "btnOpenInChrome";
			btnOpenInChrome.Size = new System.Drawing.Size( 214, 56 );
			btnOpenInChrome.TabIndex = 23;
			btnOpenInChrome.Text = "Open in Chrome";
			btnOpenInChrome.UseVisualStyleBackColor = true;
			btnOpenInChrome.Click +=  btnOpenInChrome_Click ;
			// 
			// btnOpenInEdge
			// 
			btnOpenInEdge.Location = new System.Drawing.Point( 1324, 977 );
			btnOpenInEdge.Margin = new System.Windows.Forms.Padding( 6, 8, 6, 8 );
			btnOpenInEdge.Name = "btnOpenInEdge";
			btnOpenInEdge.Size = new System.Drawing.Size( 197, 56 );
			btnOpenInEdge.TabIndex = 24;
			btnOpenInEdge.Text = "Open in Edge";
			btnOpenInEdge.UseVisualStyleBackColor = true;
			btnOpenInEdge.Click +=  btnOpenInEdge_Click ;
			// 
			// btnSelectAllPolicies
			// 
			btnSelectAllPolicies.Location = new System.Drawing.Point( 100, 977 );
			btnSelectAllPolicies.Margin = new System.Windows.Forms.Padding( 4, 5, 4, 5 );
			btnSelectAllPolicies.Name = "btnSelectAllPolicies";
			btnSelectAllPolicies.Size = new System.Drawing.Size( 184, 56 );
			btnSelectAllPolicies.TabIndex = 30;
			btnSelectAllPolicies.Text = "Select All";
			btnSelectAllPolicies.UseVisualStyleBackColor = true;
			btnSelectAllPolicies.Click +=  btnSelectAllPolicies_Click ;
			// 
			// btnDeselectAllPolicies
			// 
			btnDeselectAllPolicies.Location = new System.Drawing.Point( 290, 977 );
			btnDeselectAllPolicies.Margin = new System.Windows.Forms.Padding( 4, 5, 4, 5 );
			btnDeselectAllPolicies.Name = "btnDeselectAllPolicies";
			btnDeselectAllPolicies.Size = new System.Drawing.Size( 184, 56 );
			btnDeselectAllPolicies.TabIndex = 31;
			btnDeselectAllPolicies.Text = "Deselect All";
			btnDeselectAllPolicies.UseVisualStyleBackColor = true;
			btnDeselectAllPolicies.Click +=  btnDeselectAllPolicies_Click ;
			// 
			// btnSamlSP
			// 
			btnSamlSP.Location = new System.Drawing.Point( 1533, 977 );
			btnSamlSP.Margin = new System.Windows.Forms.Padding( 6, 8, 6, 8 );
			btnSamlSP.Name = "btnSamlSP";
			btnSamlSP.Size = new System.Drawing.Size( 197, 56 );
			btnSamlSP.TabIndex = 32;
			btnSamlSP.Text = "Saml SP";
			btnSamlSP.UseVisualStyleBackColor = true;
			btnSamlSP.Click +=  btnSamlSP_Click ;
			// 
			// showRPs
			// 
			showRPs.AutoSize = true;
			showRPs.Location = new System.Drawing.Point( 596, 987 );
			showRPs.Margin = new System.Windows.Forms.Padding( 4, 5, 4, 5 );
			showRPs.Name = "showRPs";
			showRPs.Size = new System.Drawing.Size( 202, 36 );
			showRPs.TabIndex = 34;
			showRPs.Text = "Only show RPs";
			showRPs.UseVisualStyleBackColor = true;
			showRPs.CheckedChanged +=  showRPs_CheckedChanged ;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new System.Drawing.Point( 1090, 547 );
			label6.Margin = new System.Windows.Forms.Padding( 6, 0, 6, 0 );
			label6.Name = "label6";
			label6.Size = new System.Drawing.Size( 159, 32 );
			label6.TabIndex = 35;
			label6.Text = "B2C Resource";
			// 
			// b2cResource
			// 
			b2cResource.Location = new System.Drawing.Point( 1096, 589 );
			b2cResource.Margin = new System.Windows.Forms.Padding( 6, 8, 6, 8 );
			b2cResource.Name = "b2cResource";
			b2cResource.Size = new System.Drawing.Size( 634, 39 );
			b2cResource.TabIndex = 36;
			b2cResource.TextChanged +=  b2cResource_TextChanged ;
			// 
			// getAccessToken
			// 
			getAccessToken.AutoSize = true;
			getAccessToken.Location = new System.Drawing.Point( 1098, 640 );
			getAccessToken.Margin = new System.Windows.Forms.Padding( 4, 5, 4, 5 );
			getAccessToken.Name = "getAccessToken";
			getAccessToken.Size = new System.Drawing.Size( 231, 36 );
			getAccessToken.TabIndex = 37;
			getAccessToken.Text = "Get Access Token";
			getAccessToken.UseVisualStyleBackColor = true;
			getAccessToken.CheckedChanged +=  getAccessToken_CheckedChanged ;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add( tenantTxt );
			groupBox1.Controls.Add( label5 );
			groupBox1.Controls.Add( txtAppId );
			groupBox1.Controls.Add( label4 );
			groupBox1.Controls.Add( btnLogin );
			groupBox1.Location = new System.Drawing.Point( 100, 59 );
			groupBox1.Margin = new System.Windows.Forms.Padding( 4, 5, 4, 5 );
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new System.Windows.Forms.Padding( 4, 5, 4, 5 );
			groupBox1.Size = new System.Drawing.Size( 1406, 179 );
			groupBox1.TabIndex = 38;
			groupBox1.TabStop = false;
			groupBox1.Text = "Authenticate to Graph API";
			// 
			// txtPoliciesFilter
			// 
			txtPoliciesFilter.Location = new System.Drawing.Point( 596, 458 );
			txtPoliciesFilter.Margin = new System.Windows.Forms.Padding( 6, 8, 6, 8 );
			txtPoliciesFilter.Name = "txtPoliciesFilter";
			txtPoliciesFilter.Size = new System.Drawing.Size( 433, 39 );
			txtPoliciesFilter.TabIndex = 39;
			txtPoliciesFilter.TextChanged +=  policyListFilter_TextChanged ;
			// 
			// lstAppRegistrations
			// 
			lstAppRegistrations.FormattingEnabled = true;
			lstAppRegistrations.Location = new System.Drawing.Point( 1098, 371 );
			lstAppRegistrations.Margin = new System.Windows.Forms.Padding( 6, 8, 6, 8 );
			lstAppRegistrations.Name = "lstAppRegistrations";
			lstAppRegistrations.Size = new System.Drawing.Size( 632, 40 );
			lstAppRegistrations.TabIndex = 40;
			lstAppRegistrations.SelectedIndexChanged +=  lstAppRegistrations_SelectedIndexChanged ;
			// 
			// txtReplyUrl
			// 
			txtReplyUrl.FormattingEnabled = true;
			txtReplyUrl.Location = new System.Drawing.Point( 1098, 480 );
			txtReplyUrl.Margin = new System.Windows.Forms.Padding( 6, 8, 6, 8 );
			txtReplyUrl.Name = "txtReplyUrl";
			txtReplyUrl.Size = new System.Drawing.Size( 632, 40 );
			txtReplyUrl.TabIndex = 41;
			txtReplyUrl.SelectedIndexChanged +=  txtReplyUrl_SelectedIndexChanged ;
			// 
			// txtPolicyFileFilter
			// 
			txtPolicyFileFilter.Location = new System.Drawing.Point( 100, 458 );
			txtPolicyFileFilter.Margin = new System.Windows.Forms.Padding( 6, 8, 6, 8 );
			txtPolicyFileFilter.Name = "txtPolicyFileFilter";
			txtPolicyFileFilter.Size = new System.Drawing.Size( 433, 39 );
			txtPolicyFileFilter.TabIndex = 42;
			txtPolicyFileFilter.TextChanged +=  txtPolicyFileFilter_TextChanged ;
			// 
			// B2CPolicyManager
			// 
			AutoScaleDimensions = new System.Drawing.SizeF( 13F, 32F );
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			AutoSize = true;
			BackColor = System.Drawing.SystemColors.Control;
			BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			ClientSize = new System.Drawing.Size( 1814, 1683 );
			Controls.Add( txtPolicyFileFilter );
			Controls.Add( txtReplyUrl );
			Controls.Add( lstAppRegistrations );
			Controls.Add( txtPoliciesFilter );
			Controls.Add( groupBox1 );
			Controls.Add( getAccessToken );
			Controls.Add( b2cResource );
			Controls.Add( label6 );
			Controls.Add( showRPs );
			Controls.Add( btnSamlSP );
			Controls.Add( btnDeselectAllPolicies );
			Controls.Add( btnSelectAllPolicies );
			Controls.Add( btnOpenInEdge );
			Controls.Add( btnOpenInChrome );
			Controls.Add( btnOpenFolderInVSCode );
			Controls.Add( btnClearLog );
			Controls.Add( chkVerbose );
			Controls.Add( btnCopyRunNow );
			Controls.Add( label3 );
			Controls.Add( label2 );
			Controls.Add( label1 );
			Controls.Add( txtRunNow );
			Controls.Add( HTTPResponse );
			Controls.Add( btnRefrshFileList );
			Controls.Add( lstPolicyFiles );
			Controls.Add( btnUpdateSelectedPolices );
			Controls.Add( lstPolicies );
			Controls.Add( btnDeleteSelected );
			Controls.Add( btnListPolicies );
			Controls.Add( btnFetchPolicies );
			Controls.Add( policyFolderLbl );
			Controls.Add( btnSelectPolicyFolder );
			Icon = (System.Drawing.Icon)resources.GetObject( "$this.Icon" );
			Margin = new System.Windows.Forms.Padding( 6, 8, 6, 8 );
			MaximumSize = new System.Drawing.Size( 1840, 1754 );
			MinimumSize = new System.Drawing.Size( 1840, 1754 );
			Name = "B2CPolicyManager";
			StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "AAD B2C Custom Policy Manager";
			Load +=  B2CPolicyManager_Load ;
			groupBox1.ResumeLayout( false );
			groupBox1.PerformLayout();
			ResumeLayout( false );
			PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSelectPolicyFolder;
        private System.Windows.Forms.Label policyFolderLbl;
        private System.Windows.Forms.Button btnListPolicies;
        private System.Windows.Forms.Button btnFetchPolicies;
        private System.Windows.Forms.Button btnDeleteSelected;
        private System.Windows.Forms.ListBox lstPolicies;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnUpdateSelectedPolices;
        private System.Windows.Forms.CheckedListBox lstPolicyFiles;
        private System.Windows.Forms.Button btnRefrshFileList;
        private System.Windows.Forms.TextBox HTTPResponse;
        private System.Windows.Forms.TextBox txtRunNow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCopyRunNow;
        private System.Windows.Forms.TextBox tenantTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAppId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.CheckBox chkVerbose;
        private System.Windows.Forms.Button btnOpenFolderInVSCode;
        private System.Windows.Forms.Button btnOpenInChrome;
        private System.Windows.Forms.Button btnOpenInEdge;
        private System.Windows.Forms.Button btnSelectAllPolicies;
        private System.Windows.Forms.Button btnDeselectAllPolicies;
        private System.Windows.Forms.Button btnSamlSP;
        private System.Windows.Forms.CheckBox showRPs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox b2cResource;
        private System.Windows.Forms.CheckBox getAccessToken;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPoliciesFilter;
        private System.Windows.Forms.ComboBox lstAppRegistrations;
        private System.Windows.Forms.ComboBox txtReplyUrl;
		private System.Windows.Forms.TextBox txtPolicyFileFilter;
	}
}

