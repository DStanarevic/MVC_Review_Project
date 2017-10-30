using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Review_Project.Models
{
    public class Category
    {
        //This is my category model, this includes a city along with a brief description.
        [Key]
        public int ID { get; set; }
        [Display(Name ="City")]
        public string Place { get; set; }
        public string Description { get; set; }

        //This links to my foreign key in the reviews table.
        public virtual ICollection<Review> Reviews { get; set; }
    }
}