
namespace Screenshot_Tool
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.LblSaveLocation = new System.Windows.Forms.Label();
            this.LblDataType = new System.Windows.Forms.Label();
            this.TxtSaveLocation = new System.Windows.Forms.TextBox();
            this.CbxDataType = new System.Windows.Forms.ComboBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnScreenshot = new System.Windows.Forms.Button();
            this.PbPreview = new System.Windows.Forms.PictureBox();
            this.CbxScreens = new System.Windows.Forms.ComboBox();
            this.LblScreens = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PbPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // LblSaveLocation
            // 
            this.LblSaveLocation.AutoSize = true;
            this.LblSaveLocation.Location = new System.Drawing.Point(44, 41);
            this.LblSaveLocation.Name = "LblSaveLocation";
            this.LblSaveLocation.Size = new System.Drawing.Size(67, 15);
            this.LblSaveLocation.TabIndex = 0;
            this.LblSaveLocation.Text = "Speicherort";
            // 
            // LblDataType
            // 
            this.LblDataType.AutoSize = true;
            this.LblDataType.Location = new System.Drawing.Point(44, 110);
            this.LblDataType.Name = "LblDataType";
            this.LblDataType.Size = new System.Drawing.Size(70, 15);
            this.LblDataType.TabIndex = 1;
            this.LblDataType.Text = "Dateiformat";
            // 
            // TxtSaveLocation
            // 
            this.TxtSaveLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(196)))), ((int)(((byte)(195)))));
            this.TxtSaveLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSaveLocation.Location = new System.Drawing.Point(146, 33);
            this.TxtSaveLocation.Name = "TxtSaveLocation";
            this.TxtSaveLocation.ReadOnly = true;
            this.TxtSaveLocation.Size = new System.Drawing.Size(252, 23);
            this.TxtSaveLocation.TabIndex = 1;
            // 
            // CbxDataType
            // 
            this.CbxDataType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(196)))), ((int)(((byte)(195)))));
            this.CbxDataType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxDataType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbxDataType.FormattingEnabled = true;
            this.CbxDataType.Location = new System.Drawing.Point(146, 102);
            this.CbxDataType.Name = "CbxDataType";
            this.CbxDataType.Size = new System.Drawing.Size(252, 23);
            this.CbxDataType.TabIndex = 2;
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(204)))), ((int)(((byte)(203)))));
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Location = new System.Drawing.Point(146, 477);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(252, 37);
            this.BtnSave.TabIndex = 3;
            this.BtnSave.Text = "Speichern";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Visible = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(204)))), ((int)(((byte)(203)))));
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSearch.Location = new System.Drawing.Point(404, 33);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(94, 23);
            this.BtnSearch.TabIndex = 4;
            this.BtnSearch.Text = "Durchsuchen";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnScreenshot
            // 
            this.BtnScreenshot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(204)))), ((int)(((byte)(203)))));
            this.BtnScreenshot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnScreenshot.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnScreenshot.Location = new System.Drawing.Point(146, 244);
            this.BtnScreenshot.Name = "BtnScreenshot";
            this.BtnScreenshot.Size = new System.Drawing.Size(252, 61);
            this.BtnScreenshot.TabIndex = 5;
            this.BtnScreenshot.Text = "Screenshot aufnehmen";
            this.BtnScreenshot.UseVisualStyleBackColor = false;
            this.BtnScreenshot.Click += new System.EventHandler(this.BtnScreenshot_Click);
            // 
            // PbPreview
            // 
            this.PbPreview.Image = ((System.Drawing.Image)(resources.GetObject("PbPreview.Image")));
            this.PbPreview.Location = new System.Drawing.Point(549, 12);
            this.PbPreview.Name = "PbPreview";
            this.PbPreview.Size = new System.Drawing.Size(992, 635);
            this.PbPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbPreview.TabIndex = 6;
            this.PbPreview.TabStop = false;
            // 
            // CbxScreens
            // 
            this.CbxScreens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(196)))), ((int)(((byte)(195)))));
            this.CbxScreens.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxScreens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbxScreens.FormattingEnabled = true;
            this.CbxScreens.Location = new System.Drawing.Point(146, 174);
            this.CbxScreens.Name = "CbxScreens";
            this.CbxScreens.Size = new System.Drawing.Size(252, 23);
            this.CbxScreens.TabIndex = 8;
            // 
            // LblScreens
            // 
            this.LblScreens.AutoSize = true;
            this.LblScreens.Location = new System.Drawing.Point(44, 177);
            this.LblScreens.Name = "LblScreens";
            this.LblScreens.Size = new System.Drawing.Size(93, 15);
            this.LblScreens.TabIndex = 7;
            this.LblScreens.Text = "Monitorauswahl";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(145)))), ((int)(((byte)(144)))));
            this.ClientSize = new System.Drawing.Size(1553, 659);
            this.Controls.Add(this.CbxScreens);
            this.Controls.Add(this.LblScreens);
            this.Controls.Add(this.PbPreview);
            this.Controls.Add(this.BtnScreenshot);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.CbxDataType);
            this.Controls.Add(this.TxtSaveLocation);
            this.Controls.Add(this.LblDataType);
            this.Controls.Add(this.LblSaveLocation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.Text = "Screenshot Tool";
            ((System.ComponentModel.ISupportInitialize)(this.PbPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblSaveLocation;
        private System.Windows.Forms.Label LblDataType;
        private System.Windows.Forms.TextBox TxtSaveLocation;
        private System.Windows.Forms.ComboBox CbxDataType;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnScreenshot;
        private System.Windows.Forms.PictureBox PbPreview;
        private System.Windows.Forms.ComboBox CbxScreens;
        private System.Windows.Forms.Label LblScreens;
    }
}

