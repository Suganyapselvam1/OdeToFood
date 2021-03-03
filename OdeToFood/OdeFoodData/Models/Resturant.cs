using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeFoodData.Models
{
    public class Resturant
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public String Name { get; set; }
        [Display(Name="Type of food")]
        public CuisineType Cuisine { get; set; }
    }
}
