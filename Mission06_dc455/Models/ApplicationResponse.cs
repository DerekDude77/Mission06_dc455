using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_dc455.Models
{
    public class ApplicationResponse
    {
        [Key]
        [Required]
        public int EntryID { get; set; }
        [Required (ErrorMessage = "You need a movie title you silly goose")]
        public string Title { get; set; }
        [Required (ErrorMessage = "You need a year you silly goose")]
        public int Year { get; set; }
        [Required (ErrorMessage = "You need a director you silly goose")]
        public string Director { get; set; }
        [Required (ErrorMessage = "You need a rating you silly goose")]
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string LentTo { get; set; }
        [MaxLength(25)]
        public string Notes { get; set; }

        //Build Foreign Key Relationship
        [Required (ErrorMessage = "You need a category you silly goose")]
        public int CategoryID { get; set; }
        public Category Category {get; set;}

    }
}
