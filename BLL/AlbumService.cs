using DAL.Repositories.Concrete;
using Models.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace BLL
{
    public class AlbumService
    {
        public AlbumService()
        {
            _albumRepository=new AlbumRepository(new DAL.Context.AppDbContext());
        }

        AlbumRepository _albumRepository;

       

        public bool Add(Album album)
        {
            album.CreationDate = DateTime.Now;
            album.Status = Status.Active;

            return _albumRepository.Add(album);
        }


        public bool Update(Album album)
        {
            album.Status = Status.Modified;
            album.ModifiedDate = DateTime.Now;
            return _albumRepository.Update(album);
        }


        public bool Delete(int id)
        {
            Album album = GetById(id);
            return _albumRepository.Delete(album);
        }


        public Album GetById(int id)
        {
            return _albumRepository.Find(id);
        }


        // Tüm albümleri getir
        public List<Album> GetAllAlbums()
        {
            return _albumRepository.GetAllAlbums();
        }

     
       

        // Sisteme en son eklenen 10 albümü getir
        public List<Album> GetLatestAlbums()
        {
            return _albumRepository.GetLatestAlbums();
        }

        // İndirimdeki albümleri indirim oranına göre sıralayarak getir
        public List<Album> GetDiscountedAlbums()
        {
            return _albumRepository.GetDiscountedAlbums();
        }

        public bool CheckEntries(string albumName)
        {
            return _albumRepository.CheckEntries(albumName);
        }


        //satışta olan veya olmayan albümleri getirir
        public List<Album> GetAlbumsBySaleStatus(bool isOnSale)
        {
            return _albumRepository.GetAlbumsBySaleStatus(isOnSale);
        }
    }
}
