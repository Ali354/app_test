//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace TestApp.Models
{
    public class ValueAttrViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} must not be empty")]
        //[Display(Name = "Name")]
        public string Value { get; set; }


    }
}
