namespace eDepoKryptonUi
{
    partial class frmGiris
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
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.rdBtn_teknolojikAlet = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.rdBtn_araba = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.kryptonGroup1 = new ComponentFactory.Krypton.Toolkit.KryptonGroup();
            this.rdBtn_ev = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.btn_kategoriSec = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).BeginInit();
            this.kryptonGroup1.Panel.SuspendLayout();
            this.kryptonGroup1.SuspendLayout();
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
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip;
            this.kryptonLabel1.Location = new System.Drawing.Point(327, 101);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Palette = this.kryptonPalette1;
            this.kryptonLabel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonLabel1.Size = new System.Drawing.Size(334, 40);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "E-Depo\'ya Hoşgeldiniz";
            // 
            // rdBtn_teknolojikAlet
            // 
            this.rdBtn_teknolojikAlet.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdBtn_teknolojikAlet.Location = new System.Drawing.Point(3, 34);
            this.rdBtn_teknolojikAlet.Name = "rdBtn_teknolojikAlet";
            this.rdBtn_teknolojikAlet.Size = new System.Drawing.Size(139, 20);
            this.rdBtn_teknolojikAlet.TabIndex = 0;
            this.rdBtn_teknolojikAlet.Values.Text = "kryptonRadioButton1";
            this.rdBtn_teknolojikAlet.CheckedChanged += new System.EventHandler(this.rdBtn_teknolojikAlet_CheckedChanged);
            // 
            // rdBtn_araba
            // 
            this.rdBtn_araba.Location = new System.Drawing.Point(148, 34);
            this.rdBtn_araba.Name = "rdBtn_araba";
            this.rdBtn_araba.Size = new System.Drawing.Size(139, 20);
            this.rdBtn_araba.TabIndex = 1;
            this.rdBtn_araba.Values.Text = "kryptonRadioButton1";
            this.rdBtn_araba.CheckedChanged += new System.EventHandler(this.rdBtn_teknolojikAlet_CheckedChanged);
            // 
            // kryptonGroup1
            // 
            this.kryptonGroup1.Location = new System.Drawing.Point(293, 165);
            this.kryptonGroup1.Name = "kryptonGroup1";
            // 
            // kryptonGroup1.Panel
            // 
            this.kryptonGroup1.Panel.Controls.Add(this.rdBtn_teknolojikAlet);
            this.kryptonGroup1.Panel.Controls.Add(this.rdBtn_ev);
            this.kryptonGroup1.Panel.Controls.Add(this.rdBtn_araba);
            this.kryptonGroup1.Size = new System.Drawing.Size(439, 83);
            this.kryptonGroup1.TabIndex = 1;
            // 
            // rdBtn_ev
            // 
            this.rdBtn_ev.Location = new System.Drawing.Point(293, 34);
            this.rdBtn_ev.Name = "rdBtn_ev";
            this.rdBtn_ev.Size = new System.Drawing.Size(139, 20);
            this.rdBtn_ev.TabIndex = 2;
            this.rdBtn_ev.Values.Text = "kryptonRadioButton1";
            this.rdBtn_ev.CheckedChanged += new System.EventHandler(this.rdBtn_teknolojikAlet_CheckedChanged);
            // 
            // btn_kategoriSec
            // 
            this.btn_kategoriSec.Location = new System.Drawing.Point(297, 254);
            this.btn_kategoriSec.Name = "btn_kategoriSec";
            this.btn_kategoriSec.Size = new System.Drawing.Size(435, 25);
            this.btn_kategoriSec.TabIndex = 2;
            this.btn_kategoriSec.Values.Text = "Kategoriyi Seç";
            this.btn_kategoriSec.Click += new System.EventHandler(this.kategoriSec_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::eDepoKryptonUi.Properties.Resources.stock;
            this.pictureBox1.Location = new System.Drawing.Point(87, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_kategoriSec);
            this.Controls.Add(this.kryptonGroup1);
            this.Controls.Add(this.kryptonLabel1);
            this.Name = "frmGiris";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E Depo";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).EndInit();
            this.kryptonGroup1.Panel.ResumeLayout(false);
            this.kryptonGroup1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).EndInit();
            this.kryptonGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rdBtn_teknolojikAlet;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rdBtn_araba;
        private ComponentFactory.Krypton.Toolkit.KryptonGroup kryptonGroup1;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rdBtn_ev;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_kategoriSec;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

