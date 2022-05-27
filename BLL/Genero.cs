using DAL;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Genero
    {
        private DataAccess dataAccess = DataAccess.Instance();
        public int idGenero { get; set; }
        public string descripcion { get; set; }

        public Genero()
        {

        }
        public int Add()
        {
            var parameters = new DynamicParameters();
            parameters.Add("descripcion ", descripcion);
            return dataAccess.Execute("stp_genero_add", parameters);
        }
        public IEnumerable<Genero> GetAll()
        {
            return dataAccess.Query<Genero>("stp_genero_getall");
        }
        public Genero GetByID()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idGenero", idGenero);
            return dataAccess.QuerySingle<Genero>("stp_genero_getid", parameters);
        }

        public int Update()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idGenero", idGenero);
            parameters.Add("descripcion", descripcion);
            return dataAccess.Execute("stp_genero_update", parameters);
        }

    }
}
