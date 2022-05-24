namespace eDepoKryptonUi
{
    partial class frmKullaniciGiris
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
            this.components = new System.ComponentModel.Container();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.txt_Sifre = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.txt_KullaniciAdi = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btn_giris = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.BasePaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.kryptonPalette1.ButtonSpecs.FormClose.Image = global::eDepoKryptonUi.Properties.Resources.icons8_Close_18px;
            this.kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImagePressed = global::eDepoKryptonUi.Properties.Resources.icons8_Close_18px;
            this.kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImageTracking = global::eDepoKryptonUi.Properties.Resources.icons8_Close_18px;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 12;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.kryptonPalette1.LabelStyles.LabelSuperTip.StateCommon.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.GrayScaleBlue;
            this.kryptonPalette1.LabelStyles.LabelSuperTip.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonPalette1.LabelStyles.LabelSuperTip.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonPalette1.LabelStyles.LabelSuperTip.StateCommon.ShortText.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Location = new System.Drawing.Point(144, 252);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.Size = new System.Drawing.Size(246, 26);
            this.txt_Sifre.TabIndex = 2;
            this.txt_Sifre.Text = "Şifre";
            // 
            // txt_KullaniciAdi
            // 
            this.txt_KullaniciAdi.Location = new System.Drawing.Point(144, 223);
            this.txt_KullaniciAdi.Name = "txt_KullaniciAdi";
            this.txt_KullaniciAdi.Size = new System.Drawing.Size(246, 23);
            this.txt_KullaniciAdi.TabIndex = 1;
            this.txt_KullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // btn_giris
            // 
            this.btn_giris.Location = new System.Drawing.Point(144, 299);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(246, 25);
            this.btn_giris.TabIndex = 0;
            this.btn_giris.Values.Text = "Giriş";
            this.btn_giris.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::eDepoKryptonUi.Properties.Resources.icons8_user_100px;
            this.pictureBox1.Location = new System.Drawing.Point(196, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmKullaniciGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(534, 450);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.txt_KullaniciAdi);
            this.Controls.Add(this.txt_Sifre);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmKullaniciGiris";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Girişi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox txt_Sifre;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_KullaniciAdi;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_giris;
    }
}