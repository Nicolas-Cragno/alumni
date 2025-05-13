using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class Satelital_CombustibleNegocio
    {
        const string db_satelital_cb = "cantarini_control.dbo.combustible_satelital";

        public List<string> listarSatelital()
        {
            List<string> listaSatelital = new List<string>();
            AccesoDatos datos = new AccesoDatos();

            string campoListaSatelital = "SELECT nombre";
            string database = " FROM " + db_satelital_cb + ";";
            string querySatelital = campoListaSatelital + database;

            try
            {
                datos.setearConsulta(querySatelital);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    string auxSat = (string)datos.Lector["nombre"];

                    listaSatelital.Add(auxSat);
                }

                return listaSatelital;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
