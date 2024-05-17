namespace PL
{
    partial class Last10Albums
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
            listBoxSon10Album = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(450, 62);
            label1.Name = "label1";
            label1.Size = new Size(482, 45);
            label1.TabIndex = 2;
            label1.Text = "Sisteme Eklenen Son 10 Albüm";
            // 
            // listBoxSon10Album
            // 
            listBoxSon10Album.FormattingEnabled = true;
            listBoxSon10Album.Location = new Point(132, 137);
            listBoxSon10Album.Name = "listBoxSon10Album";
            listBoxSon10Album.Size = new Size(1242, 612);
            listBoxSon10Album.TabIndex = 3;
            // 
            // Last10Albums
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1547, 830);
            Controls.Add(listBoxSon10Album);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Last10Albums";
            Text = "Last 10 Albums";
            Load += Last10Albums_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBoxSon10Album;
    }
}