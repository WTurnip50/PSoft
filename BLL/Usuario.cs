using DAL;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class Usuario
    {
        private DataAccess dataAccess = DataAccess.Instance();
        public int IdUsuario { get; set; }
        public string nombre { get; set; }
        public string password { get; set; }
        public bool activo { get; set; }

        public Usuario() { }


        public Usuario Login()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@nombre", nombre);
            parameters.Add("@password", password);
            return dataAccess.QuerySingleOrDefault<Usuario>("stp_usuario_login", parameters);
        }
        public Usuario SU()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@nombre", nombre);
            parameters.Add("@password", password);
            return dataAccess.QuerySingleOrDefault<Usuario>("stp_usuario_loginsu", parameters);
        }

        public Usuario getById()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idUsuario", IdUsuario);
            return dataAccess.QuerySingle<Usuario>("stp_usuario_getid", parameters);
        }
        public IEnumerable<Usuario> GetAll()
        {
            return dataAccess.Query<Usuario>("stp_usuario_getall");
        }
    }
}
