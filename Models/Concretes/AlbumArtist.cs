using Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Concretes
{
    public class AlbumArtist:BaseEntity
    {
        public int AlbumArtistId {  get; set; }
        public int AlbumId { get; set; }
        public int ArtistId { get; set; }


        // Navigation properties
        public virtual Album? Album { get; set; }
        public virtual Artist? Artist { get; set; }
    }
}
