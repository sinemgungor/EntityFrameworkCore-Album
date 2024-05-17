using Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Concretes
{
    public class Artist:BaseEntity
    {
        public int ArtistId { get; set; }
        public string Name { get; set; }
        public string? Surname { get; set; }

        //navigation propertie
        public virtual ICollection<AlbumArtist> AlbumArtists { get; set; }
    }
}
