using DataAccessDapper.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessDapper.DataAccess
{
    public interface IProductConnection
    {
        List<ProductDTO> GetProducts(List<string> productTags);
    }
}
