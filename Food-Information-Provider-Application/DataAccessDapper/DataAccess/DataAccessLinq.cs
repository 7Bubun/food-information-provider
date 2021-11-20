using DataAccessDapper.Model;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessDapper.DataAccess
{
    public static class DataAccessLinq
    {
        public static IEnumerable<ProductDTO> DistinctProducts
            (this IEnumerable<ProductDTO> products)
        {
            return products.GroupBy(product => product.Product_Name)
                    .Select(pn => pn.First());
        }

        public static IEnumerable<ProductViewModel> MapToViewModels
            (this IEnumerable<ProductDTO> products)
        {
            return products.DistinctProducts().Select(dto => new ProductViewModel(dto));
        }
    }
}
