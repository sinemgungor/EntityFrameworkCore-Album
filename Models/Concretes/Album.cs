using Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Concretes
{
    public class Album:BaseEntity
    {
        public int AlbumId { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal Price { get; set; }
        public decimal? Discount { get; set; }
        public bool IsOnSale { get; set; }

 
        //navigation propertie
        public virtual ICollection<AlbumArtist> AlbumArtists { get; set; }

        public override string ToString()
        {
            return $"{Name}  - {ReleaseDate.ToShortDateString()} - {Price:C2} - Discount: {(Discount.HasValue ? Discount.ToString() + "%" : "None")} - {(IsOnSale ? "On Sale" : "Not on Sale")}";
        }

     
    }
}
