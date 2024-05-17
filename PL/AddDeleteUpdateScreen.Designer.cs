namespace PLayer
{
    partial class AddDeleteUpdateScreen
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
            listBoxAlbumler = new ListBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxAlbumAdi = new TextBox();
            textBoxFiyat = new TextBox();
            label1 = new Label();
            textBoxSanatciAdi = new TextBox();
            radioButtonEvet = new RadioButton();
            radioButtonHayır = new RadioButton();
            buttonAlbumEkle = new Button();
            buttonGuncelle = new Button();
            buttonSil = new Button();
            button1 = new Button();
            dateTimePickerYayinTarihi = new DateTimePicker();
            label7 = new Label();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // listBoxAlbumler
            // 
            listBoxAlbumler.FormattingEnabled = true;
            listBoxAlbumler.HorizontalScrollbar = true;
            listBoxAlbumler.Location = new Point(926, 60);
            listBoxAlbumler.Name = "listBoxAlbumler";
            listBoxAlbumler.Size = new Size(778, 612);
            listBoxAlbumler.TabIndex = 0;
            listBoxAlbumler.SelectedIndexChanged += listBoxAlbumler_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 10.875F);
            label2.Location = new Point(226, 82);
            label2.Name = "label2";
            label2.Size = new Size(156, 40);
            label2.TabIndex = 2;
            label2.Text = "Albüm Adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 10.875F);
            label3.Location = new Point(202, 171);
            label3.Name = "label3";
            label3.Size = new Size(180, 40);
            label3.TabIndex = 3;
            label3.Text = "Yayın Tarihi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 10.875F);
            label4.Location = new Point(287, 260);
            label4.Name = "label4";
            label4.Size = new Size(95, 40);
            label4.TabIndex = 4;
            label4.Text = "Fiyatı";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 10.875F);
            label5.Location = new Point(36, 359);
            label5.Name = "label5";
            label5.Size = new Size(346, 40);
            label5.TabIndex = 5;
            label5.Text = "Satışı devam ediyor mu?";
            // 
            // textBoxAlbumAdi
            // 
            textBoxAlbumAdi.Location = new Point(442, 82);
            textBoxAlbumAdi.Name = "textBoxAlbumAdi";
            textBoxAlbumAdi.Size = new Size(322, 39);
            textBoxAlbumAdi.TabIndex = 6;
            // 
            // textBoxFiyat
            // 
            textBoxFiyat.Location = new Point(442, 263);
            textBoxFiyat.Name = "textBoxFiyat";
            textBoxFiyat.Size = new Size(322, 39);
            textBoxFiyat.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 10.875F);
            label1.Location = new Point(207, 553);
            label1.Name = "label1";
            label1.Size = new Size(174, 40);
            label1.TabIndex = 10;
            label1.Text = "Sanatçı Adı";
            // 
            // textBoxSanatciAdi
            // 
            textBoxSanatciAdi.Location = new Point(442, 556);
            textBoxSanatciAdi.Name = "textBoxSanatciAdi";
            textBoxSanatciAdi.Size = new Size(321, 39);
            textBoxSanatciAdi.TabIndex = 12;
            // 
            // radioButtonEvet
            // 
            radioButtonEvet.AutoSize = true;
            radioButtonEvet.Location = new Point(442, 363);
            radioButtonEvet.Name = "radioButtonEvet";
            radioButtonEvet.Size = new Size(90, 36);
            radioButtonEvet.TabIndex = 14;
            radioButtonEvet.TabStop = true;
            radioButtonEvet.Text = "Evet";
            radioButtonEvet.UseVisualStyleBackColor = true;
            // 
            // radioButtonHayır
            // 
            radioButtonHayır.AutoSize = true;
            radioButtonHayır.Location = new Point(632, 363);
            radioButtonHayır.Name = "radioButtonHayır";
            radioButtonHayır.Size = new Size(100, 36);
            radioButtonHayır.TabIndex = 14;
            radioButtonHayır.TabStop = true;
            radioButtonHayır.Text = "Hayır";
            radioButtonHayır.UseVisualStyleBackColor = true;
            // 
            // buttonAlbumEkle
            // 
            buttonAlbumEkle.Font = new Font("Comic Sans MS", 12F);
            buttonAlbumEkle.Location = new Point(507, 736);
            buttonAlbumEkle.Name = "buttonAlbumEkle";
            buttonAlbumEkle.Size = new Size(195, 98);
            buttonAlbumEkle.TabIndex = 15;
            buttonAlbumEkle.Text = "Kaydet";
            buttonAlbumEkle.UseVisualStyleBackColor = true;
            buttonAlbumEkle.Click += buttonAlbumEkle_Click;
            // 
            // buttonGuncelle
            // 
            buttonGuncelle.Font = new Font("Comic Sans MS", 12F);
            buttonGuncelle.Location = new Point(1163, 736);
            buttonGuncelle.Name = "buttonGuncelle";
            buttonGuncelle.Size = new Size(166, 98);
            buttonGuncelle.TabIndex = 16;
            buttonGuncelle.Text = "Güncelle";
            buttonGuncelle.UseVisualStyleBackColor = true;
            buttonGuncelle.Click += buttonGuncelle_Click;
            // 
            // buttonSil
            // 
            buttonSil.Font = new Font("Comic Sans MS", 12F);
            buttonSil.Location = new Point(1377, 736);
            buttonSil.Name = "buttonSil";
            buttonSil.Size = new Size(160, 98);
            buttonSil.TabIndex = 16;
            buttonSil.Text = "Sil";
            buttonSil.UseVisualStyleBackColor = true;
            buttonSil.Click += buttonSil_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Olive;
            button1.Location = new Point(855, 60);
            button1.Name = "button1";
            button1.Size = new Size(12, 794);
            button1.TabIndex = 17;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            // 
            // dateTimePickerYayinTarihi
            // 
            dateTimePickerYayinTarihi.Location = new Point(442, 174);
            dateTimePickerYayinTarihi.Name = "dateTimePickerYayinTarihi";
            dateTimePickerYayinTarihi.Size = new Size(322, 39);
            dateTimePickerYayinTarihi.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.Location = new Point(180, 460);
            label7.Name = "label7";
            label7.Size = new Size(202, 40);
            label7.TabIndex = 19;
            label7.Text = "İndirim Oranı";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(442, 464);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(321, 39);
            numericUpDown1.TabIndex = 20;
            // 
            // AddDeleteUpdateScreen
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1768, 901);
            Controls.Add(numericUpDown1);
            Controls.Add(label7);
            Controls.Add(dateTimePickerYayinTarihi);
            Controls.Add(button1);
            Controls.Add(buttonSil);
            Controls.Add(buttonGuncelle);
            Controls.Add(buttonAlbumEkle);
            Controls.Add(radioButtonHayır);
            Controls.Add(radioButtonEvet);
            Controls.Add(textBoxSanatciAdi);
            Controls.Add(label1);
            Controls.Add(textBoxFiyat);
            Controls.Add(textBoxAlbumAdi);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listBoxAlbumler);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddDeleteUpdateScreen";
            Text = "AddDeleteUpdateScreen";
            Load += AddDeleteUpdateScreen_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxAlbumler;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxAlbumAdi;
        private TextBox textBoxFiyat;
        private Label label1;
        private TextBox textBoxSanatciAdi;
        private RadioButton radioButtonEvet;
        private RadioButton radioButtonHayır;
        private Button buttonAlbumEkle;
        private Button buttonGuncelle;
        private Button buttonSil;
        private Button button1;
        private DateTimePicker dateTimePickerYayinTarihi;
        private Label label7;
        private NumericUpDown numericUpDown1;
    }
}