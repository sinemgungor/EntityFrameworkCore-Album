using DAL.Repositories.Concrete;
using Models.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AlbumArtistService
    {
        public AlbumArtistService()
        {
            _albumArtistRepository = new AlbumArtistRepository(new DAL.Context.AppDbContext());
        }

        AlbumArtistRepository _albumArtistRepository;

        // Bir albümün sanatçılarını getir
        public List<Artist> GetArtistsByAlbumId(int albumId)
        {
            return _albumArtistRepository.GetArtistsByAlbumId(albumId);
        }

        // Bir sanatçının albümlerini getir
        public List<Album> GetAlbumsByArtistId(int artistId)
        {
            return _albumArtistRepository.GetAlbumsByArtistId(artistId);
        }

       
    }
}
