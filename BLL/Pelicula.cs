using DAL;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Pelicula
    {
        private DataAccess dataAccess = DataAccess.Instance();
        public int idPelicula { get; set; }
        public string titulo { get; set; }
        public int idGenero { get; set; }
        public string año { get; set; }
        public float duracion { get; set; }
        public int idLenguaje { get; set; }
        public decimal costo { get; set; }
        public string sinopsis { get; set; }
        public string folio { get; set; }
        public int idDirector { get; set; }
        //public int idCliente { get; set; }
        public int idUsuario { get; set; }

        public Pelicula()
        {

        }

        public int AddCarrito()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@folio", folio);
            parameters.Add("@idPelicula", idPelicula);
            parameters.Add("@costo", costo);
            //parameters.Add("@idCLiente", idCliente);
            parameters.Add("@idUsuario", idUsuario);
            return dataAccess.Execute("stp_carrito_add", parameters);
        }
        public int Add()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idGenero", idGenero);
            parameters.Add("@idDirector", idDirector);
            parameters.Add("@titulo", titulo);
            parameters.Add("@año", año);
            parameters.Add("@duracion", duracion);
            parameters.Add("@idLenguaje", idLenguaje);
            parameters.Add("@costo", costo);
            parameters.Add("@sinopsis", sinopsis);
          //  parameters.Add("@folio", folio);
            return dataAccess.Execute("stp_pelicula_add", parameters);
        }
        public int Delete()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idPelicula", idDirector);
            return dataAccess.Execute("stp_pelicula_delete", parameters);
        }
        public Pelicula getByTitulo()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@titulo", titulo);
            return dataAccess.QuerySingle<Pelicula>("stp_pelicula_getTitulo", parameters);
        }
        public IEnumerable<Pelicula> GetAll()
        {
            return dataAccess.Query<Pelicula>("stp_pelicula_getall");
        }
       

        public int Update()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idPelicula", idPelicula);
            parameters.Add("@idGenero", idGenero);
            parameters.Add("@idDirector", idDirector);
            parameters.Add("@titulo", titulo);
            parameters.Add("@año", idPelicula);
            parameters.Add("@duracion", idPelicula);
           // parameters.Add("@idLenguaje", folio);
            parameters.Add("@costo", idPelicula);
            parameters.Add("@sipnosis", costo);
            //parameters.Add("@folio", idCliente);
            return dataAccess.Execute("stp_lenguas_update", parameters);
        }

    }
}
