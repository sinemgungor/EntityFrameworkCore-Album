using Models.Concretes;
using PL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLayer
{
    public partial class AnaEkran : Form
    {
        public AnaEkran(User user, Form form)
        {
            InitializeComponent();
            _user = user;
            _form = form;
        }

        User _user;
        Form _form;

        private void çIKIŞYAPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AnaEkran_Load(object sender, EventArgs e)
        {
            AddDeleteUpdateScreen addDeleteUpdateScreen = new AddDeleteUpdateScreen();
            addDeleteUpdateScreen.MdiParent = this;
            addDeleteUpdateScreen.Dock = DockStyle.Fill;
            this.Width = addDeleteUpdateScreen.Width;
            this.Height = addDeleteUpdateScreen.Height + 60;
            addDeleteUpdateScreen.Show();
        }

        private void satışıDurmuşAlbümlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotOnSale notOnSale = new NotOnSale();
            notOnSale.MdiParent = this;
            notOnSale.Dock = DockStyle.Fill;
            this.Width = notOnSale.Width;
            this.Height = notOnSale.Height + 60;
            notOnSale.Show();
        }

        private void albümBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDeleteUpdateScreen addDeleteUpdateScreen = new AddDeleteUpdateScreen();
            addDeleteUpdateScreen.MdiParent = this;
            addDeleteUpdateScreen.Dock = DockStyle.Fill;
            this.Width = addDeleteUpdateScreen.Width;
            this.Height = addDeleteUpdateScreen.Height + 60;
            addDeleteUpdateScreen.Show();
        }

        private void satışıDevamEdenAlbümlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnSale onSale = new OnSale();
            onSale.MdiParent = this;
            onSale.Dock = DockStyle.Fill;
            this.Width = onSale.Width;
            this.Height = onSale.Height + 60;
            onSale.Show();
        }

        private void son10AlbümToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Last10Albums last10Albums = new Last10Albums();
            last10Albums.MdiParent = this;
            last10Albums.Dock = DockStyle.Fill;
            this.Width = last10Albums.Width;
            this.Height = last10Albums.Height + 60;
            last10Albums.Show();
        }

        private void indirimdekiAlbümlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DiscountedAlbums discountedAlbums = new DiscountedAlbums();
            discountedAlbums.MdiParent = this;
            discountedAlbums.Dock=DockStyle.Fill;
            this.Width= discountedAlbums.Width;
            this.Height= discountedAlbums.Height + 60;
            discountedAlbums.Show();
        }
    }
}
