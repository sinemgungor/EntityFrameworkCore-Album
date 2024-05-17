namespace PL
{
    partial class DiscountedAlbums
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
            listBoxIndirimdekiAlbumler = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(525, 62);
            label1.Name = "label1";
            label1.Size = new Size(339, 45);
            label1.TabIndex = 3;
            label1.Text = "İndirimdeki Albümler";
            // 
            // listBoxIndirimdekiAlbumler
            // 
            listBoxIndirimdekiAlbumler.FormattingEnabled = true;
            listBoxIndirimdekiAlbumler.Location = new Point(101, 140);
            listBoxIndirimdekiAlbumler.Name = "listBoxIndirimdekiAlbumler";
            listBoxIndirimdekiAlbumler.Size = new Size(1302, 612);
            listBoxIndirimdekiAlbumler.TabIndex = 4;
            // 
            // DiscountedAlbums
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1547, 830);
            Controls.Add(listBoxIndirimdekiAlbumler);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DiscountedAlbums";
            Text = "DiscountedAlbums";
            Load += DiscountedAlbums_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBoxIndirimdekiAlbumler;
    }
}