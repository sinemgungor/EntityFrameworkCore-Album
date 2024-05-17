namespace PL
{
    partial class NotOnSale
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
            listBoxSatisiDurmusAlbumler = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(580, 58);
            label1.Name = "label1";
            label1.Size = new Size(375, 45);
            label1.TabIndex = 0;
            label1.Text = "Satışı Durmuş Albümler";
            // 
            // listBoxSatisiDurmusAlbumler
            // 
            listBoxSatisiDurmusAlbumler.FormattingEnabled = true;
            listBoxSatisiDurmusAlbumler.Location = new Point(132, 141);
            listBoxSatisiDurmusAlbumler.Name = "listBoxSatisiDurmusAlbumler";
            listBoxSatisiDurmusAlbumler.Size = new Size(1291, 676);
            listBoxSatisiDurmusAlbumler.TabIndex = 1;
            // 
            // NotOnSale
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1573, 901);
            Controls.Add(listBoxSatisiDurmusAlbumler);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NotOnSale";
            Text = "NotOnSale";
            Load += NotOnSale_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBoxSatisiDurmusAlbumler;
    }
}