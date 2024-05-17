namespace PL
{
    partial class OnSale
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
            label1 = new Label();
            listBoxSatisisDevamEdenAlbumler = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(496, 38);
            label1.Name = "label1";
            label1.Size = new Size(444, 45);
            label1.TabIndex = 1;
            label1.Text = "Satışı Devam Eden Albümler";
            // 
            // listBoxSatisisDevamEdenAlbumler
            // 
            listBoxSatisisDevamEdenAlbumler.FormattingEnabled = true;
            listBoxSatisisDevamEdenAlbumler.Location = new Point(109, 132);
            listBoxSatisisDevamEdenAlbumler.Name = "listBoxSatisisDevamEdenAlbumler";
            listBoxSatisisDevamEdenAlbumler.Size = new Size(1285, 612);
            listBoxSatisisDevamEdenAlbumler.TabIndex = 2;
            // 
            // OnSale
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1547, 830);
            Controls.Add(listBoxSatisisDevamEdenAlbumler);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OnSale";
            Text = "Form1";
            Load += OnSale_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBoxSatisisDevamEdenAlbumler;
    }
}