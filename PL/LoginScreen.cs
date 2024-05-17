using BLL;
using Models.Concretes;
using Models.Enums;
using System.Text;
using System.Security.Cryptography;

namespace PLayer

{
    public partial class GiriþEkrani : Form
    {
        public GiriþEkrani()
        {
            InitializeComponent();
            userService = new();
        }

        UserService userService;

        private void checkBoxGöster_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGöster.Checked)
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
            //mevcut formdan createaccount screene geçiþ yapýlýr
            HesapOlusturmaEkrani form = new HesapOlusturmaEkrani();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void GiriþEkrani_Load(object sender, EventArgs e)
        {
            textBoxSifre.UseSystemPasswordChar = true;
        }

        private void buttonGiriþYap_Click(object sender, EventArgs e)
        {
            
            int control = 0;
            // Tüm kullanýcýlarý kontrol et
            foreach (User us in userService.GetActiveUsers())
            {
                //kullanýcý bilgisi kontrolü yapýlýr
                if (us.UserName == textBoxKullaniciAdi.Text && us.Password == sha256_hash(textBoxSifre.Text) && us.Status != Status.Passive)
                {
                    // Ana ekraný baþlat, bu formu gizle
                    AnaEkran anaEkran = new AnaEkran(us, this);
                    anaEkran.Show();
                    control = 1;
                    this.Hide();
                }
            }
            if (control == 0) // Kontrol deðiþkeni hala 0 ise, yanlýþ kullanýcý giriþi
            {
                MessageBox.Show("Kullanýcý adý veya þifre hatalý!");
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
