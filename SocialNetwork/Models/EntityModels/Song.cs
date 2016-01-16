using System.Data.Entity.ModelConfiguration;

namespace SocialNetwork.Models
{
    public class Song
    {
        public int SongId { get; set; }
        public string Name { get; set; }
        public string Artist { get; set; }
        public string Lyrics { get; set; }
        public string FilePath { get; set; }
    }

    public class SongConfiguration : EntityTypeConfiguration<Song>
    {
        public SongConfiguration()
        {
            HasKey(s => s.SongId);
        }
    }
}