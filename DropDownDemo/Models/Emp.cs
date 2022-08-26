using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DropDownDemo.Models
{
    public class Emp
    {
        [Required]
        public string name { get; set; }
        [Required]
        public int country { get; set; }
    }
}