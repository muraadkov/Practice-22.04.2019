using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicBandsHomeWork22._04._2019
{
    public class MusicBand
    {
        public string Name { get; set; }
        public Guid Id { get; set; } = Guid.NewGuid();
        public virtual ICollection<Song> Songs { get; set; }
    }
}
