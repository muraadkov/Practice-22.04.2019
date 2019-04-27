using System;
using System.Collections.Generic;

namespace MusicBandsHomeWork22._04._2019
{
    public class Song
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Words { get; set; }
        public string DuringSounding { get; set; }
        public int Rating { get; set; }
        public virtual MusicBand MusicBand { get; set; }
    }
}