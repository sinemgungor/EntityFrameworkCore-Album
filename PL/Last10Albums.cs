using BLL;
using Models.Concretes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL
{
    public partial class Last10Albums : Form
    {
        public Last10Albums()
        {
            InitializeComponent();
            albumService = new();
            albumArtistService = new();
        }
        
        AlbumService albumService;
        AlbumArtistService albumArtistService;
        private void Last10Albums_Load(object sender, EventArgs e)
        {
            List<Album> latestAlbums = albumService.GetLatestAlbums();

            // Listbox'a albümleri ekle
            foreach (Album album in latestAlbums)
            {
                List<Artist> artists = albumArtistService.GetArtistsByAlbumId(album.AlbumId);
                string artistNames = GetArtistNames(artists);
                listBoxSon10Album.Items.Add($"{album.Name} - {artistNames}");
            }
        }

        private string GetArtistNames(List<Artist> artists)
        {
            if (artists == null || artists.Count == 0)
            {
                return "Unknown Artist";
            }

            List<string> artistNames = new List<string>();

            foreach (var artist in artists)
            {
                artistNames.Add($"{artist.Name} {artist.Surname}");
            }
            return string.Join(", ", artistNames);
        }
    }
}
