using BLL;
using Microsoft.IdentityModel.Tokens;
using Models.Concretes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Utilities;

namespace PLayer
{
    public partial class HesapOlusturmaEkrani : Form
    {
        public HesapOlusturmaEkrani()
        {
            InitializeComponent();
            userService = new();
            userDetailService = new();
        }

        UserService userService;
        UserDetailService userDetailService;

        private void checkBoxGöster_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGöster.Checked)
            {
                textBoxSifre.UseSystemPasswordChar = false;
                textBoxSifreyiDogrula.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxSifre.UseSystemPasswordChar = true;
                textBoxSifreyiDogrula.UseSystemPasswordChar=false;
            }
        }

        private void HesapOlusturmaEkrani_Load(object sender, EventArgs e)
        {
            textBoxSifre.UseSystemPasswordChar = true;
            textBoxSifreyiDogrula.UseSystemPasswordChar = true;
        }

        private void buttonKaydol_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxKullaniciAdi.Text))
            {
                MessageBox.Show("Kullanıcı adı boş bırakılamaz!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxIsim.Text))
            {
                MessageBox.Show("İsim boş bırakılamaz!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            int spaceCount = textBoxIsim.Text.Count(c => c == ' ');
            bool isValidTurkishLettersAndSpaces = Regex.IsMatch(textBoxIsim.Text, @"^[a-zA-ZığüşöçİĞÜŞÖÇ ]+$");

            if (!isValidTurkishLettersAndSpaces || spaceCount > 4)
            {
                MessageBox.Show("İsim alanına sadece Türkçe karakter girilebilir!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxSoyisim.Text))
            {
                MessageBox.Show("Soy isim alanı boş geçilemez!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            int spaceCount2 = textBoxSoyisim.Text.Count(c => c == ' ');
            bool isValidTurkishLettersAndSpaces2 = Regex.IsMatch(textBoxSoyisim.Text, @"^[a-zA-ZığüşöçİĞÜŞÖÇ ]+$");

            if (!isValidTurkishLettersAndSpaces2 || spaceCount2 > 4)
            {
                MessageBox.Show("Soy isim alanına sadece Türkçe karakter girilebilir!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxSifre.Text))
            {
                MessageBox.Show("Şifre alanı boş geçilemez!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!IsPasswordValid(textBoxSifre.Text))
            {
                MessageBox.Show("Şifre en az 8 karakter uzunluğunda olmalı, 2 büyük harf ve en az 2 özel karakter içermelidir!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxSifreyiDogrula.Text))
            {
                MessageBox.Show("Şifre doğrulama alanı boş geçilemez!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBoxSifre.Text != textBoxSifreyiDogrula.Text) // şifre doğrulama ve şifre uyuşuyor mu
            {
                MessageBox.Show("Şifreler aynı değil..", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User user = new User();
            user.UserName = textBoxKullaniciAdi.Text;
            user.Password = sha256_hash(textBoxSifre.Text);
           
            UserDetail userDetail = new UserDetail();
            userDetail.Name = textBoxIsim.Text;
            userDetail.Surname = textBoxSoyisim.Text;

            user.UserDetail = userDetail;
            userService.Add(user);

            MessageBox.Show("Hesap başarıyla oluşturuldu...");
            this.Close();
        }

        
        private string sha256_hash(string password)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(password)).Select(l => l.ToString("X2")));
            }
        }

        public static bool IsPasswordValid(string password)
        {

            return password.Length >= 8 &&
                   password.Count(char.IsUpper) >= 2 &&
                   password.Count(char.IsLower) >= 3 &&
                   password.Count(c => "!:+*".Contains(c)) >= 2;
        }


        public void FormClear()
        {
            textBoxIsim.Text = string.Empty;
            textBoxKullaniciAdi.Text = string.Empty;
            textBoxSifre.Text = string.Empty;
            textBoxSoyisim.Text = string.Empty;
            textBoxSifreyiDogrula.Text = string.Empty;
        }
    }
}
