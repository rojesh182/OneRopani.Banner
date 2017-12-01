using System;
using System.ComponentModel.DataAnnotations;

namespace OneRopani.Banner.Models
{
    public class News
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime AddedDate { get; set; }

        [Required(ErrorMessage = "Body is can't be empty")]
        public string NewsContent { get; set; }
    }
}