using DAL.Context;
using Microsoft.EntityFrameworkCore;
using Models.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Concrete
{
    public class AlbumArtistRepository : CRUD<AlbumArtist>
    {
        public AlbumArtistRepository(AppDbContext dbContext) : base(dbContext)
        {
            _dbContext = new();
        }

        AppDbContext _dbContext;

        // Bir albümün sanatçılarını getir
        public List<Artist> GetArtistsByAlbumId(int albumId)
        {
            return _dbContext.AlbumArtists
                .Where(aa => aa.AlbumId == albumId)
                .Select(aa => aa.Artist)
                .ToList();
        }

        // Bir sanatçının albümlerini getir
        public List<Album> GetAlbumsByArtistId(int artistId)
        {
            return _dbContext.AlbumArtists
                .Where(aa => aa.ArtistId == artistId)
                .Select(aa => aa.Album)
                .ToList();
        }
    }
}
