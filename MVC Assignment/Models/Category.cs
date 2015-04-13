
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Assignment.Models
{
    public class Category
    {
        [Key]
        public int PkVacationCatId { get; set; }
        public string  VacationCatName{ get; set; }
    }
}