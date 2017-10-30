using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_Review_Project.Models
{
    public class Review
    {
        //This is my reviews table, here I included a brief description along with a review score.
        [Key]
        public int ID { get; set; }

        // Name of the site you would like to visit.
        [Display(Name ="Location")]
        public string Place { get; set; } 

        //What kind of location is it, this can be a museum or a park or anything of that sort.
        [Display(Name ="Type of location")]
        public string Type { get; set; }

        //Where exactly is it located in the city.
        [Display(Name ="Where is it?")]
        public string Location { get; set; }

        //Brief description of the site and review.
        [Display(Name ="Description")]
        [MaxLength(200)]
        public string Description { get; set; }

        //The review score for the site.
        [Display(Name ="Fun Score")]
        [Range(0, 5)]
        public double FunLevel { get; set; }

        //Start Time
        [DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Time)]
        public DateTime From { get; set; }

        //End Time
        [DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Time)]
        public DateTime Until { get; set; }

        //This brings over the Category ID and sets it as my foreign key.
        [ForeignKey("Category"), Display(Name = "City")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}