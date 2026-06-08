namespace XDokumMaliyetHesaplama
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
            this.cmbParcalar = new System.Windows.Forms.ComboBox();
            this.lblParca = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.btnKirilim = new System.Windows.Forms.Button();
            this.lblToplamMaliyet = new System.Windows.Forms.Label();
            this.dgvDetay = new System.Windows.Forms.DataGridView();
            this.picParcaResmi = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picParcaResmi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbParcalar
            // 
            this.cmbParcalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbParcalar.FormattingEnabled = true;
            this.cmbParcalar.Location = new System.Drawing.Point(437, 103);
            this.cmbParcalar.Name = "cmbParcalar";
            this.cmbParcalar.Size = new System.Drawing.Size(543, 32);
            this.cmbParcalar.TabIndex = 0;
            this.cmbParcalar.SelectedIndexChanged += new System.EventHandler(this.cmbParcalar_SelectedIndexChanged);
            // 
            // lblParca
            // 
            this.lblParca.AutoSize = true;
            this.lblParca.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblParca.Location = new System.Drawing.Point(217, 103);
            this.lblParca.Name = "lblParca";
            this.lblParca.Size = new System.Drawing.Size(165, 29);
            this.lblParca.TabIndex = 1;
            this.lblParca.Text = "Parça Seçiniz:";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.Location = new System.Drawing.Point(384, 246);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(216, 53);
            this.btnHesapla.TabIndex = 2;
            this.btnHesapla.Text = "Maliyeti Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // btnKirilim
            // 
            this.btnKirilim.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKirilim.Location = new System.Drawing.Point(712, 246);
            this.btnKirilim.Name = "btnKirilim";
            this.btnKirilim.Size = new System.Drawing.Size(216, 53);
            this.btnKirilim.TabIndex = 3;
            this.btnKirilim.Text = "Kırılımı Göster";
            this.btnKirilim.UseVisualStyleBackColor = true;
            this.btnKirilim.Click += new System.EventHandler(this.btnKirilim_Click);
            // 
            // lblToplamMaliyet
            // 
            this.lblToplamMaliyet.AutoSize = true;
            this.lblToplamMaliyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamMaliyet.Location = new System.Drawing.Point(380, 351);
            this.lblToplamMaliyet.Name = "lblToplamMaliyet";
            this.lblToplamMaliyet.Size = new System.Drawing.Size(293, 29);
            this.lblToplamMaliyet.TabIndex = 4;
            this.lblToplamMaliyet.Text = "Toplam Maliyet: --- USD";
            // 
            // dgvDetay
            // 
            this.dgvDetay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetay.Location = new System.Drawing.Point(66, 471);
            this.dgvDetay.Name = "dgvDetay";
            this.dgvDetay.Size = new System.Drawing.Size(1359, 185);
            this.dgvDetay.TabIndex = 5;
            // 
            // picParcaResmi
            // 
            this.picParcaResmi.BackColor = System.Drawing.SystemColors.ControlLight;
            this.picParcaResmi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picParcaResmi.Location = new System.Drawing.Point(1017, 28);
            this.picParcaResmi.Name = "picParcaResmi";
            this.picParcaResmi.Size = new System.Drawing.Size(408, 405);
            this.picParcaResmi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picParcaResmi.TabIndex = 6;
            this.picParcaResmi.TabStop = false;
            // 
            // picLogo
            // 
            this.picLogo.Location = new System.Drawing.Point(12, 18);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(300, 60);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 7;
            this.picLogo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1475, 668);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.picParcaResmi);
            this.Controls.Add(this.dgvDetay);
            this.Controls.Add(this.lblToplamMaliyet);
            this.Controls.Add(this.btnKirilim);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.lblParca);
            this.Controls.Add(this.cmbParcalar);
            this.Name = "Form1";
            this.Text = "Lotus Döküm - Maliyet Hesaplama Sistemi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picParcaResmi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbParcalar;
        private System.Windows.Forms.Label lblParca;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Button btnKirilim;
        private System.Windows.Forms.Label lblToplamMaliyet;
        private System.Windows.Forms.DataGridView dgvDetay;
        private System.Windows.Forms.PictureBox picParcaResmi;
        private System.Windows.Forms.PictureBox picLogo;
    }
}

