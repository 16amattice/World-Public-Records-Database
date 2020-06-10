namespace World_Public_Records_Database
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recentSearchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fAQsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firstname = new System.Windows.Forms.Label();
            this.middlename = new System.Windows.Forms.Label();
            this.lastname = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.firstnametext = new System.Windows.Forms.TextBox();
            this.middlenametext = new System.Windows.Forms.TextBox();
            this.lastnametext = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(350, 24);
            this.MainMenu.TabIndex = 1;
            this.MainMenu.Text = "MainMenu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recentSearchesToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fAQsToolStripMenuItem,
            this.checkForUpdatesToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // recentSearchesToolStripMenuItem
            // 
            this.recentSearchesToolStripMenuItem.Name = "recentSearchesToolStripMenuItem";
            this.recentSearchesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.recentSearchesToolStripMenuItem.Text = "Recent Searches";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // fAQsToolStripMenuItem
            // 
            this.fAQsToolStripMenuItem.Name = "fAQsToolStripMenuItem";
            this.fAQsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fAQsToolStripMenuItem.Text = "FAQ\'s";
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "Check For Updates";
            // 
            // firstname
            // 
            this.firstname.AutoSize = true;
            this.firstname.Location = new System.Drawing.Point(56, 42);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(64, 13);
            this.firstname.TabIndex = 2;
            this.firstname.Text = "*First Name:";
            // 
            // middlename
            // 
            this.middlename.AutoSize = true;
            this.middlename.Location = new System.Drawing.Point(48, 77);
            this.middlename.Name = "middlename";
            this.middlename.Size = new System.Drawing.Size(72, 13);
            this.middlename.TabIndex = 3;
            this.middlename.Text = "Middle Name:";
            // 
            // lastname
            // 
            this.lastname.AutoSize = true;
            this.lastname.Location = new System.Drawing.Point(56, 110);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(65, 13);
            this.lastname.TabIndex = 4;
            this.lastname.Text = "*Last Name:";
            // 
            // dob
            // 
            this.dob.AutoSize = true;
            this.dob.Location = new System.Drawing.Point(48, 146);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(73, 13);
            this.dob.TabIndex = 5;
            this.dob.Text = "*Date of Birth:";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(134, 181);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(126, 23);
            this.search.TabIndex = 6;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            // 
            // firstnametext
            // 
            this.firstnametext.Location = new System.Drawing.Point(134, 39);
            this.firstnametext.Name = "firstnametext";
            this.firstnametext.Size = new System.Drawing.Size(126, 20);
            this.firstnametext.TabIndex = 7;
            // 
            // middlenametext
            // 
            this.middlenametext.Location = new System.Drawing.Point(134, 74);
            this.middlenametext.Name = "middlenametext";
            this.middlenametext.Size = new System.Drawing.Size(126, 20);
            this.middlenametext.TabIndex = 8;
            // 
            // lastnametext
            // 
            this.lastnametext.Location = new System.Drawing.Point(134, 107);
            this.lastnametext.Name = "lastnametext";
            this.lastnametext.Size = new System.Drawing.Size(126, 20);
            this.lastnametext.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(134, 139);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(126, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 232);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lastnametext);
            this.Controls.Add(this.middlenametext);
            this.Controls.Add(this.firstnametext);
            this.Controls.Add(this.search);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.middlename);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.MainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu;
            this.Name = "Form1";
            this.Text = "World Public Record Database";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recentSearchesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fAQsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.Label firstname;
        private System.Windows.Forms.Label middlename;
        private System.Windows.Forms.Label lastname;
        private System.Windows.Forms.Label dob;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox firstnametext;
        private System.Windows.Forms.TextBox middlenametext;
        private System.Windows.Forms.TextBox lastnametext;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

