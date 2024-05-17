using BLL;
using Models.Concretes;
using Models.Enums;
using System.Text;
using System.Security.Cryptography;

namespace PLayer

{
    public partial class Giri�Ekrani : Form
    {
        public Giri�Ekrani()
        {
            InitializeComponent();
            userService = new();
        }

        UserService userService;

        private void checkBoxG�ster_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxG�ster.Checked)
            {
                textBoxSifre.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxSifre.UseSystemPasswordChar = true;
            }
        }

        private void linkLabelHesapYarat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //mevcut formdan createaccount screene ge�i� yap�l�r
            HesapOlusturmaEkrani form = new HesapOlusturmaEkrani();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void Giri�Ekrani_Load(object sender, EventArgs e)
        {
            textBoxSifre.UseSystemPasswordChar = true;
        }

        private void buttonGiri�Yap_Click(object sender, EventArgs e)
        {
            
            int control = 0;
            // T�m kullan�c�lar� kontrol et
            foreach (User us in userService.GetActiveUsers())
            {
                //kullan�c� bilgisi kontrol� yap�l�r
                if (us.UserName == textBoxKullaniciAdi.Text && us.Password == sha256_hash(textBoxSifre.Text) && us.Status != Status.Passive)
                {
                    // Ana ekran� ba�lat, bu formu gizle
                    AnaEkran anaEkran = new AnaEkran(us, this);
                    anaEkran.Show();
                    control = 1;
                    this.Hide();
                }
            }
            if (control == 0) // Kontrol de�i�keni hala 0 ise, yanl�� kullan�c� giri�i
            {
                MessageBox.Show("Kullan�c� ad� veya �ifre hatal�!");
                textBoxKullaniciAdi.Clear();
                textBoxSifre.Clear();
            }
        }

        private string sha256_hash(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
            }
        }

    }
}
