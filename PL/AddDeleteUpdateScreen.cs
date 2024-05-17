using BLL;
using Models.Concretes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Models.Enums;
using DAL.Repositories.Concrete;
using System.Globalization;

namespace PLayer
{
    public partial class AddDeleteUpdateScreen : Form
    {
        public AddDeleteUpdateScreen()
        {
            InitializeComponent();
            albumService = new();
            artistService = new();
            albumArtistService = new();
        }


        AlbumService albumService;
        AlbumArtistService albumArtistService;

        ArtistService artistService;

        private void AddDeleteUpdateScreen_Load(object sender, EventArgs e)
        {
            List<Album> albums = albumService.GetAllAlbums();

            foreach (Album album in albums)
            {
                listBoxAlbumler.Items.Add(album);

            }

        }


       


        private string GetArtistNames(ICollection<AlbumArtist> albumArtists)
        {

            if (albumArtists == null)
            {
                return string.Empty;
            }

            List<string> artistNames = new List<string>();

            foreach (var albumArtist in albumArtists)
            {
                if (albumArtist.Artist != null)
                {
                    artistNames.Add(albumArtist.Artist.Name);
                }
            }
            return string.Join(", ", artistNames);
        }

        private void buttonAlbumEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxAlbumAdi.Text))
            {
                MessageBox.Show("Albüm adı boş bırakılamaz!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (albumService.CheckEntries(textBoxAlbumAdi.Text)) 
            {
                MessageBox.Show("Bu albüm daha önceden eklenmiştir!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }




            Album album = new Album();
            album.Name = textBoxAlbumAdi.Text;
            album.ReleaseDate = dateTimePickerYayinTarihi.Value;
            album.Price = Convert.ToDecimal(textBoxFiyat.Text);
            if (radioButtonEvet.Checked)
            {
                album.IsOnSale = true;
            }
            else if (radioButtonHayır.Checked)
            {
                album.IsOnSale = false;
            }
            else
            {
                album.IsOnSale = false; // Varsayılan olarak satışı durmuş olarak ayarlar
            }
            album.Discount = numericUpDown1.Value;

            Artist artist = new Artist();
            artist.Name = textBoxSanatciAdi.Text;
           

            //albüm ve sanatçı arasındaki ilişki
            album.AlbumArtists = new List<AlbumArtist>
            {
                new AlbumArtist{Album=album,Artist=artist}
            };

            albumService.Add(album);
            listBoxAlbumler.Items.Add(album);
            FormClear();
        }

        public void FormClear()
        {
            textBoxAlbumAdi.Text = string.Empty;
            textBoxFiyat.Text = string.Empty;
            textBoxSanatciAdi.Text = string.Empty;
            numericUpDown1.Value = 0;
            radioButtonEvet.Checked = false;
            radioButtonHayır.Checked = false;

        }

        Album selectedAlbum;
        private void listBoxAlbumler_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (listBoxAlbumler.SelectedItem != null)
            {
                Album selectedAlbum = (Album)listBoxAlbumler.SelectedItem;

                List<Artist> artists=albumArtistService.GetArtistsByAlbumId(selectedAlbum.AlbumId);

                textBoxAlbumAdi.Text = selectedAlbum.Name;
               
                dateTimePickerYayinTarihi.Value = selectedAlbum.ReleaseDate;
                textBoxFiyat.Text = selectedAlbum.Price.ToString();
                numericUpDown1.Value = selectedAlbum.Discount ?? 0; // Nullable bir değer olabilir, bu yüzden null ise varsayılan değeri kullanır
                radioButtonEvet.Checked = selectedAlbum.IsOnSale;
                radioButtonHayır.Checked = !selectedAlbum.IsOnSale;

                //Listboxtan seçilen albümün sanatçısının adını txtboxa yazdırır
                if (artists != null && artists.Count > 0)
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (Artist artist in artists)
                    {
                        sb.Append(artist.Name).Append(", ");
                    }
                    sb.Length -= 2; 
                    textBoxSanatciAdi.Text = sb.ToString();
                }
                else
                {
                    textBoxSanatciAdi.Text = "Sanatçı bulunamadı.";
                }


                //Listboxtan seçilen albümün sanatçısının soyadı varsa txtboxa yazdırır
                if (artists != null && artists.Count > 0)
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (Artist artist in artists)
                    {
                        sb.Append(artist.Name);
                        if (!string.IsNullOrEmpty(artist.Surname))
                        {
                            sb.Append(" ").Append(artist.Surname);
                        }
                        sb.Append(", ");
                    }
                    sb.Length -= 2;
                    textBoxSanatciAdi.Text = sb.ToString();
                }
                else
                {
                    textBoxSanatciAdi.Text = "Sanatçı bulunamadı."; 
                }
            }


           
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {

            if (listBoxAlbumler.SelectedIndex != -1)
            {
               
                string selectedAlbumInfo = listBoxAlbumler.SelectedItem.ToString();
                string[] albumInfoParts = selectedAlbumInfo.Split('-');

                
                Album selectedAlbum = new Album
                {
                    Name = textBoxAlbumAdi.Text.Trim(), 
                };

                
                selectedAlbum.ReleaseDate = dateTimePickerYayinTarihi.Value;
                decimal price;
                string cleanedPriceText = textBoxFiyat.Text.Replace("₺", "").Trim(); // Para birimi sembolünü ve gereksiz boşlukları kaldırır
                if (decimal.TryParse(cleanedPriceText, NumberStyles.Currency, CultureInfo.GetCultureInfo("tr-TR"), out price))
                {
                    // Dönüşüm başarılıysa, seçilen albümün fiyatını günceller
                    selectedAlbum.Price = price;
                }
                else
                {
                    // Dönüşüm başarısızsa, kullanıcıya hata mesajı göster
                    MessageBox.Show("Geçersiz fiyat formatı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Güncelleme işlemini durdurur
                }
                selectedAlbum.Discount = numericUpDown1.Value;
                selectedAlbum.IsOnSale = radioButtonEvet.Checked;

                // Albüm güncelleme işlemini çağırır
                albumService.Update(selectedAlbum);

                // Kullanıcıya güncelleme işleminin başarıyla gerçekleştiğine dair bilgi verme
                MessageBox.Show("Albüm güncelleme işlemi başarıyla tamamlandı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Formu temizle
                FormClear();

                // Listbox'ı günceller
                int selectedIndex = listBoxAlbumler.SelectedIndex;
                listBoxAlbumler.Items.RemoveAt(selectedIndex);
                listBoxAlbumler.Items.Insert(selectedIndex, selectedAlbum);
            }
            else
            {
                MessageBox.Show("Lütfen güncellenecek bir albüm seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            


        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            if (listBoxAlbumler.SelectedItem == null)
            {
                MessageBox.Show("Lütfen silinecek bir albüm seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Seçili albümü alır
            Album selectedAlbum = (Album)listBoxAlbumler.SelectedItem;

            // Seçili albümün ID'sini alır
            int selectedAlbumId = selectedAlbum.AlbumId;

            // Albümü siler
            bool deletionSuccessful = albumService.Delete(selectedAlbumId);

            // Silme işleminin başarılı olup olmadığını kontrol eder
            if (deletionSuccessful)
            {
                // Listeden albümü kaldırır
                listBoxAlbumler.Items.Remove(selectedAlbum);

                // Kullanıcıya başarılı bir şekilde silindiğini bildirir
                MessageBox.Show("Albüm başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Formu temizler
                FormClear();
            }
            else
            {
                // Silme işlemi başarısız olduysa kullanıcıya hata mesajı gösterir
                MessageBox.Show("Albüm silinirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }

}
