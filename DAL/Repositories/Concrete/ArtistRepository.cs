using DAL.Context;
using Models.Concretes;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Concrete
{
    public class ArtistRepository : CRUD<Artist>
    {
        public ArtistRepository(AppDbContext dbContext) : base(dbContext)
        {
            _dbContext = new();
        }

        AppDbContext _dbContext;

        public Artist GetArtistByArtistId(int artistId)
        {
            return _dbContext.Artists.FirstOrDefault(x => x.ArtistId == artistId);
        }

        public List<Artist> GetArtists()
        {
            return _dbContext.Artists.Where(x => x.Status == Status.Active).ToList();
        }
    }
}
