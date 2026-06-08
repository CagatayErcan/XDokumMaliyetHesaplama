namespace XDokumMaliyetHesaplama
{
    partial class frmServerSecim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServerSecim));
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDurum = new System.Windows.Forms.Label();
            this.btnDevam = new System.Windows.Forms.Button();
            this.btnTestBaglanti = new System.Windows.Forms.Button();
            this.cmbServerSecim = new System.Windows.Forms.ComboBox();
            this.lblServer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(165, 70);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(191, 38);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(165, 28);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(701, 31);
            this.lblBaslik.TabIndex = 1;
            this.lblBaslik.Text = "LOTUS DÖKÜM MALİYET HESAPLAMA PROGRAMI";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDurum);
            this.groupBox1.Controls.Add(this.btnDevam);
            this.groupBox1.Controls.Add(this.btnTestBaglanti);
            this.groupBox1.Controls.Add(this.cmbServerSecim);
            this.groupBox1.Controls.Add(this.lblServer);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(165, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(783, 389);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Veritabanı Bağlantı Ayarları";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.ForeColor = System.Drawing.Color.Blue;
            this.lblDurum.Location = new System.Drawing.Point(198, 93);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(0, 25);
            this.lblDurum.TabIndex = 4;
            // 
            // btnDevam
            // 
            this.btnDevam.Location = new System.Drawing.Point(318, 247);
            this.btnDevam.Name = "btnDevam";
            this.btnDevam.Size = new System.Drawing.Size(203, 55);
            this.btnDevam.TabIndex = 3;
            this.btnDevam.Text = "Devam Et";
            this.btnDevam.UseVisualStyleBackColor = true;
            this.btnDevam.Click += new System.EventHandler(this.btnDevam_Click);
            // 
            // btnTestBaglanti
            // 
            this.btnTestBaglanti.Location = new System.Drawing.Point(89, 247);
            this.btnTestBaglanti.Name = "btnTestBaglanti";
            this.btnTestBaglanti.Size = new System.Drawing.Size(203, 55);
            this.btnTestBaglanti.TabIndex = 2;
            this.btnTestBaglanti.Text = "Bağlantıyı Test Et";
            this.btnTestBaglanti.UseVisualStyleBackColor = true;
            this.btnTestBaglanti.Click += new System.EventHandler(this.btnTestBaglanti_Click);
            // 
            // cmbServerSecim
            // 
            this.cmbServerSecim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServerSecim.FormattingEnabled = true;
            this.cmbServerSecim.Location = new System.Drawing.Point(203, 30);
            this.cmbServerSecim.Name = "cmbServerSecim";
            this.cmbServerSecim.Size = new System.Drawing.Size(318, 33);
            this.cmbServerSecim.TabIndex = 1;
            this.cmbServerSecim.SelectedIndexChanged += new System.EventHandler(this.cmbServerSecim_SelectedIndexChanged);
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(29, 27);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(129, 25);
            this.lblServer.TabIndex = 0;
            this.lblServer.Text = "SQL Server:";
            // 
            // frmServerSecim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 687);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.picLogo);
            this.Name = "frmServerSecim";
            this.Text = "frmServerSecim";
            this.Load += new System.EventHandler(this.frmServerSecim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTestBaglanti;
        private System.Windows.Forms.ComboBox cmbServerSecim;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.Button btnDevam;
        private System.Windows.Forms.Label lblDurum;
    }
}