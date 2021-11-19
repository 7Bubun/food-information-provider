using DataAccessDapper.Model;
using System.Collections.Generic;

namespace DataAccessDapper.DataAccess
{
    public interface IProductConnection
    {
        List<ProductDTO> GetProducts(List<string> productTags);
    }
}
