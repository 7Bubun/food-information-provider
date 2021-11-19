using System.ComponentModel.DataAnnotations;

namespace DataAccessDapper.Model
{
    public class ProductViewModel
    {
        public ProductViewModel()
        {
        }
        public ProductViewModel(ProductDTO productDTO)
        {
            ProductName = productDTO.Product_Name;
            EnergyValue = productDTO.Energy_Value_Range;
            Pros = productDTO.Pros.Split(',');
            if (productDTO.Cons != null)
                Cons = productDTO.Cons.Split(',');
            if (productDTO.Additional_Info != null)
                AdditionalInformation = productDTO.Additional_Info;
        }

        [Display(Name = "Product name")]
        public string ProductName { get; set; }
        [Display(Name = "Energy value (per 100g)")]
        public string EnergyValue { get; set; }
        public string[] Pros { get; set; }
        
        #nullable enable
        public string[]? Cons { get; set; }

        [Display(Name = "Additional information")]
        public string? AdditionalInformation { get; set; }
    }
}
