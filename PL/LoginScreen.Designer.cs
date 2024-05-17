namespace PLayer
{
    partial class GirişEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirişEkrani));
            label1 = new Label();
            checkBoxGöster = new CheckBox();
            buttonGirişYap = new Button();
            linkLabelHesapYarat = new LinkLabel();
            label2 = new Label();
            label3 = new Label();
            textBoxSifre = new TextBox();
            textBoxKullaniciAdi = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(661, 67);
            label1.Name = "label1";
            label1.Size = new Size(350, 67);
            label1.TabIndex = 0;
            label1.Text = "Yönetici Girişi";
            // 
            // checkBoxGöster
            // 
            checkBoxGöster.AutoSize = true;
            checkBoxGöster.Font = new Font("Segoe UI", 10.125F);
            checkBoxGöster.Location = new Point(1024, 460);
            checkBoxGöster.Name = "checkBoxGöster";
            checkBoxGöster.Size = new Size(127, 41);
            checkBoxGöster.TabIndex = 22;
            checkBoxGöster.Text = "Göster";
            checkBoxGöster.UseVisualStyleBackColor = true;
            checkBoxGöster.CheckedChanged += checkBoxGöster_CheckedChanged;
            // 
            // buttonGirişYap
            // 
            buttonGirişYap.Font = new Font("Segoe UI", 10.125F);
            buttonGirişYap.Location = new Point(742, 595);
            buttonGirişYap.Margin = new Padding(5);
            buttonGirişYap.Name = "buttonGirişYap";
            buttonGirişYap.Size = new Size(187, 90);
            buttonGirişYap.TabIndex = 21;
            buttonGirişYap.Text = "GİRİŞ YAP";
            buttonGirişYap.UseVisualStyleBackColor = true;
            buttonGirişYap.Click += buttonGirişYap_Click;
            // 
            // linkLabelHesapYarat
            // 
            linkLabelHesapYarat.AutoSize = true;
            linkLabelHesapYarat.Font = new Font("Segoe UI", 10.125F);
            linkLabelHesapYarat.Location = new Point(761, 734);
            linkLabelHesapYarat.Margin = new Padding(5, 0, 5, 0);
            linkLabelHesapYarat.Name = "linkLabelHesapYarat";
            linkLabelHesapYarat.Size = new Size(157, 37);
            linkLabelHesapYarat.TabIndex = 20;
            linkLabelHesapYarat.TabStop = true;
            linkLabelHesapYarat.Text = "Hesap Yarat";
            linkLabelHesapYarat.LinkClicked += linkLabelHesapYarat_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.125F);
            label2.Location = new Point(773, 406);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(69, 37);
            label2.TabIndex = 19;
            label2.Text = "Şifre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.125F);
            label3.Location = new Point(752, 230);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(157, 37);
            label3.TabIndex = 18;
            label3.Text = "Kullancı Adı";
            // 
            // textBoxSifre
            // 
            textBoxSifre.Font = new Font("Segoe UI", 10.125F);
            textBoxSifre.Location = new Point(661, 460);
            textBoxSifre.Margin = new Padding(5);
            textBoxSifre.Name = "textBoxSifre";
            textBoxSifre.Size = new Size(342, 43);
            textBoxSifre.TabIndex = 17;
            // 
            // textBoxKullaniciAdi
            // 
            textBoxKullaniciAdi.Font = new Font("Segoe UI", 10.125F);
            textBoxKullaniciAdi.Location = new Point(661, 284);
            textBoxKullaniciAdi.Margin = new Padding(5);
            textBoxKullaniciAdi.Name = "textBoxKullaniciAdi";
            textBoxKullaniciAdi.Size = new Size(342, 43);
            textBoxKullaniciAdi.TabIndex = 16;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(540, 881);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // GirişEkrani
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1176, 876);
            Controls.Add(pictureBox1);
            Controls.Add(checkBoxGöster);
            Controls.Add(buttonGirişYap);
            Controls.Add(linkLabelHesapYarat);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(textBoxSifre);
            Controls.Add(textBoxKullaniciAdi);
            Controls.Add(label1);
            Name = "GirişEkrani";
            Text = "Yönetici Giriş";
            Load += GirişEkrani_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckBox checkBoxGöster;
        private Button buttonGirişYap;
        private LinkLabel linkLabelHesapYarat;
        private Label label2;
        private Label label3;
        private TextBox textBoxSifre;
        private TextBox textBoxKullaniciAdi;
        private PictureBox pictureBox1;
    }
}
