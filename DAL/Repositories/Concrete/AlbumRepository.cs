using DAL.Context;
using Microsoft.EntityFrameworkCore;
using Models.Concretes;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Concrete
{
    public class AlbumRepository : CRUD<Album>
    {
        public AlbumRepository(AppDbContext dbContext) : base(dbContext)
        {
            _dbContext = new();
        }

        AppDbContext _dbContext;



        // Tüm albümleri getir
        public List<Album> GetAllAlbums()
        {
            return _dbContext.Albums.ToList();
        }



   

        // Sisteme en son eklenen 10 albümü getir
        public List<Album> GetLatestAlbums()
        {
            return _dbContext.Albums.OrderByDescending(a => a.ReleaseDate).Take(10).ToList();
        }



        // İndirimdeki albümleri indirim oranına göre sıralayarak getir
        public List<Album> GetDiscountedAlbums()
        {
            return _dbContext.Albums.Where(a => a.Discount > 0).OrderByDescending(a => a.Discount).ToList();
        }


        public bool CheckEntries(string albumName)
        {
            var name = _dbContext.Albums.FirstOrDefault(x => x.Name == albumName);
            if (name == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        public List<Album> GetAlbumsBySaleStatus(bool isOnSale)
        {
            return _dbContext.Albums.Where(a => a.IsOnSale == isOnSale).ToList();
        }

    }
}
