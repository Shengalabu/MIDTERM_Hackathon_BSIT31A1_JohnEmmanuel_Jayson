using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Movie
    {
        [Key]
        [Column("movie_id")]
        public int MovieId { get; set; }
        [Required]
        [MaxLength(255)]
        [Column("title")]
        public string Title { get; set; }
        [Column("release_year")]
        public int? ReleaseYear { get; set; }
        [Column("duration_minutes")]
        public int? DurationMinutes { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("thumbnail_url")]
        public string ThumbnailUrl { get; set; }
        [Column("watch_link")]
        public string WatchLink { get; set; }
    }
}
