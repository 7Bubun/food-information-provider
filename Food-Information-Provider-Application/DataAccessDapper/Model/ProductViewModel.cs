using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessDapper.Model
{
    public class ProductViewModel
    {
        [Display(Name = "Product name")]
        public string ProductName { get; set; }
        [Display(Name = "Energy value (per 100g)")]
        public string EnergyValue { get; set; }
        public string[] Pros { get; set; }
        public string[] Cons { get; set; }

        [Display(Name = "Additional information")]
        public string AdditionalInformation { get; set; }
    }
}
