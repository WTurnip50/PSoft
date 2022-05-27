using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccess
    {
        #region singleton
        private static volatile DataAccess instance = null;
        private static readonly object padlock = new object();
        public static string conString = "Data Source = Israel-PC; Initial Catalog = P; " +
                "Integrated Security = true";
        public string InitialCatalog = "";
        public string DataSource = "";
        public string UserID = "";
        public string Password = "";
        //private byte[] Clave = Encoding.ASCII.GetBytes("xd");
        //private byte[] IV = Encoding.ASCII.GetBytes("Devjoker7.37hAES");

        private DataAccess() { }

        public static DataAccess Instance()
        {
            if (instance == null)
                lock (padlock)
                    if (instance == null)
                        instance = new DataAccess();
            return instance;
        }
        #endregion
        #region Query/Execute

        public T QuerySingle<T>(string query)
        {
            using (var con = new SqlConnection(conString))
            {
                return con.QuerySingle<T>(query, commandType:
                    CommandType.StoredProcedure, commandTimeout: 300);
            }
        }

        public T QuerySingle<T>(string query, DynamicParameters parameters)
        {
            using (var con = new SqlConnection(conString))
            {
                return con.QuerySingleOrDefault<T>(query, parameters, commandType:
                    CommandType.StoredProcedure, commandTimeout: 300);
            }
        }

        public T QuerySingleOrDefault<T>(string query, DynamicParameters parameters)
        {
            using (var con = new SqlConnection(conString))
            {
                return con.QuerySingleOrDefault<T>(query, parameters, commandType:
                    CommandType.StoredProcedure, commandTimeout: 300);
            }
        }

        public string QueryString(string query)
        {
            using (var con = new SqlConnection(conString))
            {
                return con.QuerySingle(query, commandType:
                    CommandType.StoredProcedure, commandTimeout: 300);
            }
        }

        public IEnumerable<T> Query<T>(string query)
        {
            using (var con = new SqlConnection(conString))
            {
                return con.Query<T>(query,
                    commandType: CommandType.StoredProcedure);
            }
        }
        public static IEnumerable<T> Query<T>(string query, DynamicParameters parameters)
        {
            using (var con = new SqlConnection(conString))
            {
                return con.Query<T>(query,
                    commandType: CommandType.StoredProcedure);
            }
        }
        

        public int Execute(string query, DynamicParameters parameters)
        {
            using (var con = new SqlConnection(conString))
            {
                return con.Execute(query, parameters,
                    commandType: CommandType.StoredProcedure);
            }
        }

        public int Insert(string query, DynamicParameters parameters, string fieldName)
        {
            using (var con = new SqlConnection(conString))
            {
                return (int)((IDictionary<string, object>)con.QuerySingle(query, parameters,
                    commandType: CommandType.StoredProcedure))[fieldName];
            }
        }

        #endregion

    }
}
