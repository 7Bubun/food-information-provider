using DataAccessDapper.Model;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Collections.Generic;

namespace DataAccessDapper.DataAccess
{
    public class ProductConnection : IProductConnection
    {
        private string sql = "SELECT N.PRODUCT_TAG, P.PRODUCT_NAME, P.PROS, P.CONS, P.ADDITIONAL_INFO " +
                             "FROM NAMETAGS N " +
                             "JOIN PRODUCT_DATA P ON P.PRODUCT_NAME = N.PRODUCT_NAME " +
                             "WHERE N.PRODUCT_TAG = @ProductTag ";

        public List<ProductDTO> GetProducts(List<string> productTags)
        {
            List<ProductDTO> products = new List<ProductDTO>();

            using (IDbConnection conn = DbConnectionBuilder.GetConnection())
            {
                foreach (string productTag in productTags)
                {
                    products.Add(conn.QuerySingle<ProductDTO>(sql, new { ProductTag = productTag }));

                }
            }
            return products;
        }
    }
}
