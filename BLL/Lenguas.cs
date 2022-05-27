using DAL;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Lenguas
    {
        private DataAccess dataAccess = DataAccess.Instance();
        public int idLenguaje { get; set; }
        public string descripcion { get; set; }
        public int Add()
        {
            var parameters = new DynamicParameters();
            parameters.Add("descripcion", descripcion);
            return dataAccess.Execute("stp_lenguas_add", parameters);
        }
        public Lenguas() { }
    
        public IEnumerable<Lenguas> GetAll()
        {
            return dataAccess.Query<Lenguas>("stp_lenguas_getall");
        }
        public Lenguas GetByID()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idLenguaje", idLenguaje);
            return dataAccess.QuerySingle<Lenguas>("stp_lenguas_getid", parameters);
        }

        public int Update()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idLenguaje", idLenguaje);
            parameters.Add("descripcion ", descripcion);
            return dataAccess.Execute("stp_lenguas_update", parameters);
        }

    }
}
