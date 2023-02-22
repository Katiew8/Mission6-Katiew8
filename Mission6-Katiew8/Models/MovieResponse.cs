using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6_Katiew8.Models
{
    public class MovieResponse
    {
        [Key]
        [Required] 
        public int MovieId { get; set; }
        //Category
        [Required(ErrorMessage ="Movie Category is Required")]
        public int CategoryId { get; set; }
        public CategoryTable Category { get; set; }
        //Title
        [Required(ErrorMessage = "Movie Title is Required")]
        public string Title { get; set; }
        //Year
        [Required(ErrorMessage = "Movie Year is Required")]
        public int Year { get; set; }
        //Director
        [Required(ErrorMessage = "Movie Director is Required")]
        public string Director { get; set; }
        //rating field with dropdown menu
        [Required(ErrorMessage = "Movie Rating is Required")]
        public string Rating { get; set; }
        //edited field yes/no (true/false) option - optional
        public bool Edited { get; set; }
        //lent to - optional
        public string LentTo { get; set; }
        //Notes 25 characters- optional
        [MaxLength(25)]
        public string Notes { get; set; }
        
    }
}