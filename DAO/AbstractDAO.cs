using System.Data.SqlClient;
using System.Configuration;

namespace DAO
{
    public abstract class AbstractDAO
    {
        protected SqlConnection Connect()
        {
            return new SqlConnection()
            {
                ConnectionString = ConfigurationManager.ConnectionStrings["QLKS"].ConnectionString
            };
        }
    }
}
