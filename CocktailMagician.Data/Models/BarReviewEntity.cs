using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CocktailMagician.Data.Models
{
    public class BarReviewEntity
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string UserEntityId { get; set; }
        [Required]
        public int BarEntityId { get; set; }
        public BarEntity Bar { get; set; }
        public UserEntity User { get; set; }
        [Required]
        public int Rating { get; set; }
        public string Review { get; set; }

    }
}
