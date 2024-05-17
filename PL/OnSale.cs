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
    public partial class OnSale : Form
    {
        public OnSale()
        {
            InitializeComponent();
            albumService = new();
            albumArtistService = new();
        }

        AlbumService albumService;
        AlbumArtistService albumArtistService;

        private void OnSale_Load(object sender, EventArgs e)
        {
            List<Album> activeAlbums = albumService.GetAlbumsBySaleStatus(true);

            foreach (Album album in activeAlbums)
            {
                List<Artist> artists = albumArtistService.GetArtistsByAlbumId(album.AlbumId);
                string artistNames = GetArtistNames(artists);
                listBoxSatisisDevamEdenAlbumler.Items.Add($"{album.Name} - {artistNames}");
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
