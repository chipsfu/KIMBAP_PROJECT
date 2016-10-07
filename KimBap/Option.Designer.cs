namespace KimBap
{
    partial class Option
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Option));
            this.rdKorea = new System.Windows.Forms.RadioButton();
            this.rdEnglish = new System.Windows.Forms.RadioButton();
            this.lbLanguageTeamName = new System.Windows.Forms.Label();
            this.lbTimeReload = new System.Windows.Forms.Label();
            this.cboTimeReload = new System.Windows.Forms.ComboBox();
            this.lbGMT = new System.Windows.Forms.Label();
            this.cboGMT = new System.Windows.Forms.ComboBox();
            this.lbTime_Outfile = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cboSite = new System.Windows.Forms.ComboBox();
            this.lblOdds = new System.Windows.Forms.Label();
            this.dtp_Option = new System.Windows.Forms.DateTimePicker();
            this.gbOptionMain = new System.Windows.Forms.GroupBox();
            this.gbOptionMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdKorea
            // 
            this.rdKorea.AutoSize = true;
            this.rdKorea.ForeColor = System.Drawing.Color.White;
            this.rdKorea.Location = new System.Drawing.Point(297, 65);
            this.rdKorea.Name = "rdKorea";
            this.rdKorea.Size = new System.Drawing.Size(72, 18);
            this.rdKorea.TabIndex = 0;
            this.rdKorea.Text = "Korean";
            this.rdKorea.UseVisualStyleBackColor = true;
            this.rdKorea.CheckedChanged += new System.EventHandler(this.rdKorea_CheckedChanged);
            // 
            // rdEnglish
            // 
            this.rdEnglish.AutoSize = true;
            this.rdEnglish.Checked = true;
            this.rdEnglish.ForeColor = System.Drawing.Color.White;
            this.rdEnglish.Location = new System.Drawing.Point(205, 65);
            this.rdEnglish.Name = "rdEnglish";
            this.rdEnglish.Size = new System.Drawing.Size(72, 18);
            this.rdEnglish.TabIndex = 1;
            this.rdEnglish.TabStop = true;
            this.rdEnglish.Text = "English";
            this.rdEnglish.UseVisualStyleBackColor = true;
            this.rdEnglish.CheckedChanged += new System.EventHandler(this.rdEnglish_CheckedChanged);
            // 
            // lbLanguageTeamName
            // 
            this.lbLanguageTeamName.AutoSize = true;
            this.lbLanguageTeamName.ForeColor = System.Drawing.Color.White;
            this.lbLanguageTeamName.Location = new System.Drawing.Point(32, 67);
            this.lbLanguageTeamName.Name = "lbLanguageTeamName";
            this.lbLanguageTeamName.Size = new System.Drawing.Size(148, 14);
            this.lbLanguageTeamName.TabIndex = 2;
            this.lbLanguageTeamName.Text = "Language team name";
            this.lbLanguageTeamName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbTimeReload
            // 
            this.lbTimeReload.AutoSize = true;
            this.lbTimeReload.ForeColor = System.Drawing.Color.White;
            this.lbTimeReload.Location = new System.Drawing.Point(470, 42);
            this.lbTimeReload.Name = "lbTimeReload";
            this.lbTimeReload.Size = new System.Drawing.Size(148, 14);
            this.lbTimeReload.TabIndex = 3;
            this.lbTimeReload.Text = "Time reload (minute)";
            this.lbTimeReload.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cboTimeReload
            // 
            this.cboTimeReload.FormattingEnabled = true;
            this.cboTimeReload.Location = new System.Drawing.Point(640, 39);
            this.cboTimeReload.Name = "cboTimeReload";
            this.cboTimeReload.Size = new System.Drawing.Size(162, 22);
            this.cboTimeReload.TabIndex = 4;
            // 
            // lbGMT
            // 
            this.lbGMT.AutoSize = true;
            this.lbGMT.ForeColor = System.Drawing.Color.White;
            this.lbGMT.Location = new System.Drawing.Point(144, 98);
            this.lbGMT.Name = "lbGMT";
            this.lbGMT.Size = new System.Drawing.Size(36, 14);
            this.lbGMT.TabIndex = 5;
            this.lbGMT.Text = "GMT";
            this.lbGMT.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cboGMT
            // 
            this.cboGMT.FormattingEnabled = true;
            this.cboGMT.Location = new System.Drawing.Point(205, 95);
            this.cboGMT.Name = "cboGMT";
            this.cboGMT.Size = new System.Drawing.Size(162, 22);
            this.cboGMT.TabIndex = 6;
            // 
            // lbTime_Outfile
            // 
            this.lbTime_Outfile.AutoSize = true;
            this.lbTime_Outfile.ForeColor = System.Drawing.Color.White;
            this.lbTime_Outfile.Location = new System.Drawing.Point(508, 67);
            this.lbTime_Outfile.Name = "lbTime_Outfile";
            this.lbTime_Outfile.Size = new System.Drawing.Size(110, 14);
            this.lbTime_Outfile.TabIndex = 7;
            this.lbTime_Outfile.Text = "Hour output file";
            this.lbTime_Outfile.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.White;
            this.btnOK.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.Black;
            this.btnOK.Location = new System.Drawing.Point(543, 98);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(667, 98);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnCloseClick);
            // 
            // cboSite
            // 
            this.cboSite.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSite.ForeColor = System.Drawing.Color.Black;
            this.cboSite.FormattingEnabled = true;
            this.cboSite.ItemHeight = 14;
            this.cboSite.Location = new System.Drawing.Point(205, 34);
            this.cboSite.Name = "cboSite";
            this.cboSite.Size = new System.Drawing.Size(162, 22);
            this.cboSite.TabIndex = 33;
            // 
            // lblOdds
            // 
            this.lblOdds.AutoSize = true;
            this.lblOdds.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOdds.ForeColor = System.Drawing.Color.White;
            this.lblOdds.Location = new System.Drawing.Point(92, 37);
            this.lblOdds.Name = "lblOdds";
            this.lblOdds.Size = new System.Drawing.Size(90, 14);
            this.lblOdds.TabIndex = 34;
            this.lblOdds.Text = "Server Odds";
            // 
            // dtp_Option
            // 
            this.dtp_Option.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Option.Location = new System.Drawing.Point(640, 67);
            this.dtp_Option.Name = "dtp_Option";
            this.dtp_Option.Size = new System.Drawing.Size(162, 22);
            this.dtp_Option.TabIndex = 36;
            // 
            // gbOptionMain
            // 
            this.gbOptionMain.BackColor = System.Drawing.Color.Transparent;
            this.gbOptionMain.Controls.Add(this.dtp_Option);
            this.gbOptionMain.Controls.Add(this.lblOdds);
            this.gbOptionMain.Controls.Add(this.cboSite);
            this.gbOptionMain.Controls.Add(this.btnClose);
            this.gbOptionMain.Controls.Add(this.btnOK);
            this.gbOptionMain.Controls.Add(this.lbTime_Outfile);
            this.gbOptionMain.Controls.Add(this.cboGMT);
            this.gbOptionMain.Controls.Add(this.lbGMT);
            this.gbOptionMain.Controls.Add(this.cboTimeReload);
            this.gbOptionMain.Controls.Add(this.lbTimeReload);
            this.gbOptionMain.Controls.Add(this.lbLanguageTeamName);
            this.gbOptionMain.Controls.Add(this.rdEnglish);
            this.gbOptionMain.Controls.Add(this.rdKorea);
            this.gbOptionMain.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOptionMain.ForeColor = System.Drawing.Color.White;
            this.gbOptionMain.Location = new System.Drawing.Point(28, 15);
            this.gbOptionMain.Name = "gbOptionMain";
            this.gbOptionMain.Size = new System.Drawing.Size(845, 157);
            this.gbOptionMain.TabIndex = 0;
            this.gbOptionMain.TabStop = false;
            this.gbOptionMain.Text = "Option Show Schedule";
            // 
            // Option
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(901, 194);
            this.Controls.Add(this.gbOptionMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "Option";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Option_FormClosed);
            this.Load += new System.EventHandler(this.Option_Load);
            this.gbOptionMain.ResumeLayout(false);
            this.gbOptionMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rdKorea;
        private System.Windows.Forms.RadioButton rdEnglish;
        private System.Windows.Forms.Label lbLanguageTeamName;
        private System.Windows.Forms.Label lbTimeReload;
        private System.Windows.Forms.ComboBox cboTimeReload;
        private System.Windows.Forms.Label lbGMT;
        private System.Windows.Forms.ComboBox cboGMT;
        private System.Windows.Forms.Label lbTime_Outfile;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.ComboBox cboSite;
        private System.Windows.Forms.Label lblOdds;
        private System.Windows.Forms.DateTimePicker dtp_Option;
        private System.Windows.Forms.GroupBox gbOptionMain;
    }
}