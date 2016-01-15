using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SocialNetwork.Models
{
    public class Song
    {
        public Guid SongId { get; set; }
        public string Name { get; set; }
        public string Artist { get; set; }
        public string Lyrics { get; set; }
        public string FilePath { get; set; }

        public virtual User Publisher { get; set; }
    }
}