using DAL.Repositories.Concrete;
using Models.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ArtistService
    {
        public ArtistService()
        {
            _artistRepository = new ArtistRepository(new DAL.Context.AppDbContext());
        }

        ArtistRepository _artistRepository;

        // ArtistId'ye göre bir sanatçıyı getirir
        public Artist GetArtistByArtistId(int artistId)
        {
            return _artistRepository.GetArtistByArtistId(artistId);
        }

        // Aktif sanatçıları getirir
        public List<Artist> GetArtists()
        {
            return _artistRepository.GetArtists();
        }
    }
}
