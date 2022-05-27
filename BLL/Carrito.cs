using DAL;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Carrito
    {
        private DataAccess dataAccess = DataAccess.Instance();
        public int idCarrito { get; set; }
        public string folio { get; set; }
        public int idPelicula { get; set; }
        public decimal costo { get; set; }
        public int idUsuario { get; set; }
        
        public Carrito()
        {

        }
       
        public Carrito getByFolio()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@folio", folio);
            return dataAccess.QuerySingle<Carrito>("stp_carrito_getFolio", parameters);
        }

        public Carrito delete()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idCarrito", idCarrito);
            return dataAccess.QuerySingle<Carrito>("stp_carrito_delete", parameters);
        }
        public IEnumerable<Carrito> GetAll()
        {
            return dataAccess.Query<Carrito>("stp_carrito_getall");
        }

    }
}
