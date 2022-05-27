using DAL;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Director
    {
        private DataAccess dataAccess = DataAccess.Instance();
        public int idDirector { get; set; }
        public string nombre { get; set; }

        public Director()
        {

        }
        public int Add()
        {
            var parameters = new DynamicParameters();
            parameters.Add("nombre", nombre);
          
            return dataAccess.Execute("stp_director_add", parameters);
        }

        public int Delete()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idDirector", idDirector);
            return dataAccess.Execute("stp_director_delete", parameters);
        }

        public IEnumerable<Director> GetAll()
        {
            return dataAccess.Query<Director>("stp_director_getall");
        }
        public int Update()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idDirector", idDirector);
            parameters.Add("nombre", nombre);
            return dataAccess.Execute("stp_director_update", parameters);
        }

    }




}
