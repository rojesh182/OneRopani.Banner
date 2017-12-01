using System;
using System.ComponentModel.DataAnnotations;

namespace OneRopani.Banner.Models
{
    public class TheBanner
    {
        public int Id { get; set; }

        [Required]
        public string Path { get; set; }

        [Required]
        [StringLength(128)]
        public string Title { get; set; }

        [Required]
        public string BannerUrl { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
    }
}