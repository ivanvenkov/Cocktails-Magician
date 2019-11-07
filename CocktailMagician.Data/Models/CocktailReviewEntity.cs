using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CocktailMagician.Data.Models
{
    public class CocktailReviewEntity
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string UserEntityId { get; set; }
        [Required]
        public int CocktailEntityId { get; set; }
        public CocktailEntity Cocktail { get; set; }
        public UserEntity User { get; set; }
        [Required]
        public int Rating { get; set; }
        public string Review { get; set; }
    }
}
