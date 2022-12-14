//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using AppDbContext.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace TestApp.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} must not be empty")]
        //[Display(CategoryId = "CategoryId")]
        public int CategoryId { get; set; }
        //[Display(Price = "Price")]
        public int Price { get; set; }
        //[Display(Dicount = "Dicount")]
        public int? Dicount { get; set; }
        //[Display(Category = "Category")]

        public virtual CategoryViewModel Category { get; set; }


    }
}
