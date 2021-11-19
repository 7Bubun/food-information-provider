using DataAccessDapper.Model;
using Dapper;
using System.Data;
using System.Collections.Generic;

namespace DataAccessDapper.DataAccess
{
    public class ProductConnection : IProductConnection
    {
        public ProductConnection(string connectionString)
        {
            this.connectionString = connectionString;
        }

        private string sql = "SELECT N.PRODUCT_TAG, P.PRODUCT_NAME, P.PROS, P.CONS, P.ADDITIONAL_INFO " +
                             "FROM NAMETAGS N " +
                             "JOIN PRODUCT_DATA P ON P.PRODUCT_NAME = N.PRODUCT_NAME " +
                             "WHERE N.PRODUCT_TAG = @ProductTag ";
        private readonly string connectionString;

        public List<ProductDTO> GetProducts(List<string> productTags)
        {
            List<ProductDTO> products = new List<ProductDTO>();

            using (IDbConnection conn = DbConnectionBuilder.GetConnection(connectionString))
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
