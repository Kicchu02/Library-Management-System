namespace LibraryManagement
{
    partial class MainWindow
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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageBookDetails = new System.Windows.Forms.TabPage();
            this.panelBookDetailsTable = new System.Windows.Forms.Panel();
            this.buttonApplyFilter = new System.Windows.Forms.Button();
            this.labelFilters = new System.Windows.Forms.Label();
            this.textBoxPublishedYear = new System.Windows.Forms.TextBox();
            this.textBoxPublication = new System.Windows.Forms.TextBox();
            this.textBoxAuthorName = new System.Windows.Forms.TextBox();
            this.textBoxBookName = new System.Windows.Forms.TextBox();
            this.textBoxBookID = new System.Windows.Forms.TextBox();
            this.tabPageStudentDetails = new System.Windows.Forms.TabPage();
            this.panelStudentDetailsTable = new System.Windows.Forms.Panel();
            this.buttonSearchStudentDetails = new System.Windows.Forms.Button();
            this.textBoxStudentUSN = new System.Windows.Forms.TextBox();
            this.labelStudentUSN = new System.Windows.Forms.Label();
            this.tabPageStaffDetails = new System.Windows.Forms.TabPage();
            this.panelStaffDetailsTable = new System.Windows.Forms.Panel();
            this.buttonGetStaffDetails = new System.Windows.Forms.Button();
            this.textBoxStaffID = new System.Windows.Forms.TextBox();
            this.labelStaffID = new System.Windows.Forms.Label();
            this.tabPageAbout = new System.Windows.Forms.TabPage();
            this.labelSourceCode = new System.Windows.Forms.Label();
            this.linkLabelSourceCodeLink = new System.Windows.Forms.LinkLabel();
            this.labelAboutInformation = new System.Windows.Forms.Label();
            this.tabControlMain.SuspendLayout();
            this.tabPageBookDetails.SuspendLayout();
            this.tabPageStudentDetails.SuspendLayout();
            this.tabPageStaffDetails.SuspendLayout();
            this.tabPageAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.tabPageBookDetails);
            this.tabControlMain.Controls.Add(this.tabPageStudentDetails);
            this.tabControlMain.Controls.Add(this.tabPageStaffDetails);
            this.tabControlMain.Controls.Add(this.tabPageAbout);
            this.tabControlMain.Location = new System.Drawing.Point(12, 12);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(776, 426);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageBookDetails
            // 
            this.tabPageBookDetails.Controls.Add(this.panelBookDetailsTable);
            this.tabPageBookDetails.Controls.Add(this.buttonApplyFilter);
            this.tabPageBookDetails.Controls.Add(this.labelFilters);
            this.tabPageBookDetails.Controls.Add(this.textBoxPublishedYear);
            this.tabPageBookDetails.Controls.Add(this.textBoxPublication);
            this.tabPageBookDetails.Controls.Add(this.textBoxAuthorName);
            this.tabPageBookDetails.Controls.Add(this.textBoxBookName);
            this.tabPageBookDetails.Controls.Add(this.textBoxBookID);
            this.tabPageBookDetails.Location = new System.Drawing.Point(4, 24);
            this.tabPageBookDetails.Name = "tabPageBookDetails";
            this.tabPageBookDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBookDetails.Size = new System.Drawing.Size(768, 398);
            this.tabPageBookDetails.TabIndex = 0;
            this.tabPageBookDetails.Text = "Books Details";
            this.tabPageBookDetails.UseVisualStyleBackColor = true;
            // 
            // panelBookDetailsTable
            // 
            this.panelBookDetailsTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBookDetailsTable.Location = new System.Drawing.Point(6, 37);
            this.panelBookDetailsTable.Name = "panelBookDetailsTable";
            this.panelBookDetailsTable.Size = new System.Drawing.Size(756, 355);
            this.panelBookDetailsTable.TabIndex = 7;
            // 
            // buttonApplyFilter
            // 
            this.buttonApplyFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonApplyFilter.Location = new System.Drawing.Point(612, 7);
            this.buttonApplyFilter.Name = "buttonApplyFilter";
            this.buttonApplyFilter.Size = new System.Drawing.Size(150, 23);
            this.buttonApplyFilter.TabIndex = 6;
            this.buttonApplyFilter.Text = "Apply Filter";
            this.buttonApplyFilter.UseVisualStyleBackColor = true;
            // 
            // labelFilters
            // 
            this.labelFilters.AutoSize = true;
            this.labelFilters.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFilters.Location = new System.Drawing.Point(6, 9);
            this.labelFilters.Name = "labelFilters";
            this.labelFilters.Size = new System.Drawing.Size(55, 17);
            this.labelFilters.TabIndex = 5;
            this.labelFilters.Text = "Filters : ";
            // 
            // textBoxPublishedYear
            // 
            this.textBoxPublishedYear.Location = new System.Drawing.Point(491, 8);
            this.textBoxPublishedYear.Name = "textBoxPublishedYear";
            this.textBoxPublishedYear.Size = new System.Drawing.Size(100, 23);
            this.textBoxPublishedYear.TabIndex = 4;
            // 
            // textBoxPublication
            // 
            this.textBoxPublication.Location = new System.Drawing.Point(385, 8);
            this.textBoxPublication.Name = "textBoxPublication";
            this.textBoxPublication.Size = new System.Drawing.Size(100, 23);
            this.textBoxPublication.TabIndex = 3;
            // 
            // textBoxAuthorName
            // 
            this.textBoxAuthorName.Location = new System.Drawing.Point(279, 8);
            this.textBoxAuthorName.Name = "textBoxAuthorName";
            this.textBoxAuthorName.Size = new System.Drawing.Size(100, 23);
            this.textBoxAuthorName.TabIndex = 2;
            // 
            // textBoxBookName
            // 
            this.textBoxBookName.Location = new System.Drawing.Point(173, 8);
            this.textBoxBookName.Name = "textBoxBookName";
            this.textBoxBookName.Size = new System.Drawing.Size(100, 23);
            this.textBoxBookName.TabIndex = 1;
            // 
            // textBoxBookID
            // 
            this.textBoxBookID.Location = new System.Drawing.Point(67, 8);
            this.textBoxBookID.Name = "textBoxBookID";
            this.textBoxBookID.Size = new System.Drawing.Size(100, 23);
            this.textBoxBookID.TabIndex = 0;
            // 
            // tabPageStudentDetails
            // 
            this.tabPageStudentDetails.Controls.Add(this.panelStudentDetailsTable);
            this.tabPageStudentDetails.Controls.Add(this.buttonSearchStudentDetails);
            this.tabPageStudentDetails.Controls.Add(this.textBoxStudentUSN);
            this.tabPageStudentDetails.Controls.Add(this.labelStudentUSN);
            this.tabPageStudentDetails.Location = new System.Drawing.Point(4, 24);
            this.tabPageStudentDetails.Name = "tabPageStudentDetails";
            this.tabPageStudentDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStudentDetails.Size = new System.Drawing.Size(768, 398);
            this.tabPageStudentDetails.TabIndex = 1;
            this.tabPageStudentDetails.Text = "Student Details";
            this.tabPageStudentDetails.UseVisualStyleBackColor = true;
            // 
            // panelStudentDetailsTable
            // 
            this.panelStudentDetailsTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelStudentDetailsTable.Location = new System.Drawing.Point(6, 35);
            this.panelStudentDetailsTable.Name = "panelStudentDetailsTable";
            this.panelStudentDetailsTable.Size = new System.Drawing.Size(756, 357);
            this.panelStudentDetailsTable.TabIndex = 3;
            // 
            // buttonSearchStudentDetails
            // 
            this.buttonSearchStudentDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearchStudentDetails.Location = new System.Drawing.Point(612, 5);
            this.buttonSearchStudentDetails.Name = "buttonSearchStudentDetails";
            this.buttonSearchStudentDetails.Size = new System.Drawing.Size(150, 23);
            this.buttonSearchStudentDetails.TabIndex = 2;
            this.buttonSearchStudentDetails.Text = "Search Details";
            this.buttonSearchStudentDetails.UseVisualStyleBackColor = true;
            // 
            // textBoxStudentUSN
            // 
            this.textBoxStudentUSN.Location = new System.Drawing.Point(109, 6);
            this.textBoxStudentUSN.Name = "textBoxStudentUSN";
            this.textBoxStudentUSN.Size = new System.Drawing.Size(200, 23);
            this.textBoxStudentUSN.TabIndex = 1;
            // 
            // labelStudentUSN
            // 
            this.labelStudentUSN.AutoSize = true;
            this.labelStudentUSN.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelStudentUSN.Location = new System.Drawing.Point(6, 7);
            this.labelStudentUSN.Name = "labelStudentUSN";
            this.labelStudentUSN.Size = new System.Drawing.Size(97, 17);
            this.labelStudentUSN.TabIndex = 0;
            this.labelStudentUSN.Text = "Student USN : ";
            // 
            // tabPageStaffDetails
            // 
            this.tabPageStaffDetails.Controls.Add(this.panelStaffDetailsTable);
            this.tabPageStaffDetails.Controls.Add(this.buttonGetStaffDetails);
            this.tabPageStaffDetails.Controls.Add(this.textBoxStaffID);
            this.tabPageStaffDetails.Controls.Add(this.labelStaffID);
            this.tabPageStaffDetails.Location = new System.Drawing.Point(4, 24);
            this.tabPageStaffDetails.Name = "tabPageStaffDetails";
            this.tabPageStaffDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStaffDetails.Size = new System.Drawing.Size(768, 398);
            this.tabPageStaffDetails.TabIndex = 3;
            this.tabPageStaffDetails.Text = "Staff Details";
            this.tabPageStaffDetails.UseVisualStyleBackColor = true;
            // 
            // panelStaffDetailsTable
            // 
            this.panelStaffDetailsTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelStaffDetailsTable.Location = new System.Drawing.Point(6, 35);
            this.panelStaffDetailsTable.Name = "panelStaffDetailsTable";
            this.panelStaffDetailsTable.Size = new System.Drawing.Size(756, 357);
            this.panelStaffDetailsTable.TabIndex = 3;
            // 
            // buttonGetStaffDetails
            // 
            this.buttonGetStaffDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGetStaffDetails.Location = new System.Drawing.Point(612, 6);
            this.buttonGetStaffDetails.Name = "buttonGetStaffDetails";
            this.buttonGetStaffDetails.Size = new System.Drawing.Size(150, 23);
            this.buttonGetStaffDetails.TabIndex = 2;
            this.buttonGetStaffDetails.Text = "Get Details";
            this.buttonGetStaffDetails.UseVisualStyleBackColor = true;
            // 
            // textBoxStaffID
            // 
            this.textBoxStaffID.Location = new System.Drawing.Point(75, 6);
            this.textBoxStaffID.Name = "textBoxStaffID";
            this.textBoxStaffID.Size = new System.Drawing.Size(200, 23);
            this.textBoxStaffID.TabIndex = 1;
            // 
            // labelStaffID
            // 
            this.labelStaffID.AutoSize = true;
            this.labelStaffID.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelStaffID.Location = new System.Drawing.Point(6, 8);
            this.labelStaffID.Name = "labelStaffID";
            this.labelStaffID.Size = new System.Drawing.Size(63, 17);
            this.labelStaffID.TabIndex = 0;
            this.labelStaffID.Text = "Staff ID : ";
            // 
            // tabPageAbout
            // 
            this.tabPageAbout.Controls.Add(this.labelSourceCode);
            this.tabPageAbout.Controls.Add(this.linkLabelSourceCodeLink);
            this.tabPageAbout.Controls.Add(this.labelAboutInformation);
            this.tabPageAbout.Location = new System.Drawing.Point(4, 24);
            this.tabPageAbout.Name = "tabPageAbout";
            this.tabPageAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAbout.Size = new System.Drawing.Size(768, 398);
            this.tabPageAbout.TabIndex = 2;
            this.tabPageAbout.Text = "About";
            this.tabPageAbout.UseVisualStyleBackColor = true;
            // 
            // labelSourceCode
            // 
            this.labelSourceCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSourceCode.AutoSize = true;
            this.labelSourceCode.Location = new System.Drawing.Point(334, 380);
            this.labelSourceCode.Name = "labelSourceCode";
            this.labelSourceCode.Size = new System.Drawing.Size(83, 15);
            this.labelSourceCode.TabIndex = 2;
            this.labelSourceCode.Text = "Source Code : ";
            // 
            // linkLabelSourceCodeLink
            // 
            this.linkLabelSourceCodeLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelSourceCodeLink.AutoSize = true;
            this.linkLabelSourceCodeLink.Location = new System.Drawing.Point(423, 380);
            this.linkLabelSourceCodeLink.Name = "linkLabelSourceCodeLink";
            this.linkLabelSourceCodeLink.Size = new System.Drawing.Size(339, 15);
            this.linkLabelSourceCodeLink.TabIndex = 1;
            this.linkLabelSourceCodeLink.TabStop = true;
            this.linkLabelSourceCodeLink.Text = "https://github.com/Kicchu02/Library-Management-System.git";
            this.linkLabelSourceCodeLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSourceCodeLink_LinkClicked);
            // 
            // labelAboutInformation
            // 
            this.labelAboutInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAboutInformation.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAboutInformation.Location = new System.Drawing.Point(6, 3);
            this.labelAboutInformation.Name = "labelAboutInformation";
            this.labelAboutInformation.Size = new System.Drawing.Size(756, 377);
            this.labelAboutInformation.TabIndex = 0;
            this.labelAboutInformation.Text = "Product : Library Management System\r\nVersion : v1.0.0\r\nAuthor : Narayana Murthy. " +
    "B\r\nOperating System : Microsoft Windows\r\nArchitecture : x86_64";
            this.labelAboutInformation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlMain);
            this.MinimumSize = new System.Drawing.Size(816, 488);
            this.Name = "MainWindow";
            this.Text = "Library Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControlMain.ResumeLayout(false);
            this.tabPageBookDetails.ResumeLayout(false);
            this.tabPageBookDetails.PerformLayout();
            this.tabPageStudentDetails.ResumeLayout(false);
            this.tabPageStudentDetails.PerformLayout();
            this.tabPageStaffDetails.ResumeLayout(false);
            this.tabPageStaffDetails.PerformLayout();
            this.tabPageAbout.ResumeLayout(false);
            this.tabPageAbout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControlMain;
        private TabPage tabPageBookDetails;
        private TabPage tabPageStudentDetails;
        private TabPage tabPageStaffDetails;
        private TabPage tabPageAbout;
        private Label labelAboutInformation;
        private TextBox textBoxPublishedYear;
        private TextBox textBoxPublication;
        private TextBox textBoxAuthorName;
        private TextBox textBoxBookName;
        private TextBox textBoxBookID;
        private Button buttonApplyFilter;
        private Label labelFilters;
        private Panel panelBookDetailsTable;
        private Label labelStudentUSN;
        private Panel panelStudentDetailsTable;
        private Button buttonSearchStudentDetails;
        private TextBox textBoxStudentUSN;
        private Panel panelStaffDetailsTable;
        private Button buttonGetStaffDetails;
        private TextBox textBoxStaffID;
        private Label labelStaffID;
        private Label labelSourceCode;
        private LinkLabel linkLabelSourceCodeLink;
    }
}