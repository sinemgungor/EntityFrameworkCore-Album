namespace PLayer
{
    partial class AnaEkran
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
            menuStrip1 = new MenuStrip();
            albümBilgileriToolStripMenuItem = new ToolStripMenuItem();
            satışıDurmuşAlbümlerToolStripMenuItem = new ToolStripMenuItem();
            satışıDevamEdenAlbümlerToolStripMenuItem = new ToolStripMenuItem();
            son10AlbümToolStripMenuItem = new ToolStripMenuItem();
            indirimdekiAlbümlerToolStripMenuItem = new ToolStripMenuItem();
            çIKIŞYAPToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { albümBilgileriToolStripMenuItem, satışıDurmuşAlbümlerToolStripMenuItem, satışıDevamEdenAlbümlerToolStripMenuItem, son10AlbümToolStripMenuItem, indirimdekiAlbümlerToolStripMenuItem, çIKIŞYAPToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1768, 42);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // albümBilgileriToolStripMenuItem
            // 
            albümBilgileriToolStripMenuItem.Name = "albümBilgileriToolStripMenuItem";
            albümBilgileriToolStripMenuItem.Size = new Size(190, 38);
            albümBilgileriToolStripMenuItem.Text = "Albüm Bilgileri";
            albümBilgileriToolStripMenuItem.Click += albümBilgileriToolStripMenuItem_Click;
            // 
            // satışıDurmuşAlbümlerToolStripMenuItem
            // 
            satışıDurmuşAlbümlerToolStripMenuItem.Name = "satışıDurmuşAlbümlerToolStripMenuItem";
            satışıDurmuşAlbümlerToolStripMenuItem.Size = new Size(284, 38);
            satışıDurmuşAlbümlerToolStripMenuItem.Text = "Satışı Durmuş Albümler";
            satışıDurmuşAlbümlerToolStripMenuItem.Click += satışıDurmuşAlbümlerToolStripMenuItem_Click;
            // 
            // satışıDevamEdenAlbümlerToolStripMenuItem
            // 
            satışıDevamEdenAlbümlerToolStripMenuItem.Name = "satışıDevamEdenAlbümlerToolStripMenuItem";
            satışıDevamEdenAlbümlerToolStripMenuItem.Size = new Size(335, 38);
            satışıDevamEdenAlbümlerToolStripMenuItem.Text = "Satışı Devam Eden Albümler";
            satışıDevamEdenAlbümlerToolStripMenuItem.Click += satışıDevamEdenAlbümlerToolStripMenuItem_Click;
            // 
            // son10AlbümToolStripMenuItem
            // 
            son10AlbümToolStripMenuItem.Name = "son10AlbümToolStripMenuItem";
            son10AlbümToolStripMenuItem.Size = new Size(185, 38);
            son10AlbümToolStripMenuItem.Text = "Son 10 Albüm";
            son10AlbümToolStripMenuItem.Click += son10AlbümToolStripMenuItem_Click;
            // 
            // indirimdekiAlbümlerToolStripMenuItem
            // 
            indirimdekiAlbümlerToolStripMenuItem.Name = "indirimdekiAlbümlerToolStripMenuItem";
            indirimdekiAlbümlerToolStripMenuItem.Size = new Size(258, 38);
            indirimdekiAlbümlerToolStripMenuItem.Text = "İndirimdeki Albümler";
            indirimdekiAlbümlerToolStripMenuItem.Click += indirimdekiAlbümlerToolStripMenuItem_Click;
            // 
            // çIKIŞYAPToolStripMenuItem
            // 
            çIKIŞYAPToolStripMenuItem.Name = "çIKIŞYAPToolStripMenuItem";
            çIKIŞYAPToolStripMenuItem.Size = new Size(134, 38);
            çIKIŞYAPToolStripMenuItem.Text = "ÇIKIŞ YAP";
            çIKIŞYAPToolStripMenuItem.Click += çIKIŞYAPToolStripMenuItem_Click;
            // 
            // AnaEkran
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1768, 900);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "AnaEkran";
            Load += AnaEkran_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem albümBilgileriToolStripMenuItem;
        private ToolStripMenuItem satışıDurmuşAlbümlerToolStripMenuItem;
        private ToolStripMenuItem satışıDevamEdenAlbümlerToolStripMenuItem;
        private ToolStripMenuItem son10AlbümToolStripMenuItem;
        private ToolStripMenuItem indirimdekiAlbümlerToolStripMenuItem;
        private ToolStripMenuItem çIKIŞYAPToolStripMenuItem;
    }
}