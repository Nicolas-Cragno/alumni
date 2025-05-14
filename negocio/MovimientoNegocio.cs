using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class MovimientoNegocio
    {
        const string db_movimientos = "cantarini_control.dbo.movimientos";

        public List<Movimiento> listarMovimientos()
        {
            List<Movimiento> listaMovimientos = new List<Movimiento>();
            AccesoDatos datos = new AccesoDatos();

            string campoListaMovimientos = "SELECT idMovimiento, idTipo, dni, interno, idFurgon, idCliente, fecha, destino, observaciones";
            string database = " FROM " + db_movimientos + ";";
            string queryMovimientos = campoListaMovimientos + database;

            try
            {
                datos.setearConsulta(queryMovimientos);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Movimiento auxMovimiento = new Movimiento();
                    int auxTipo = (int)datos.Lector["idTipo"];
                    int auxDni = (int)datos.Lector["dni"];
                    int auxCliente = (int)datos.Lector["idCliente"];

                    auxMovimiento.Id_Movimiento = (int)datos.Lector["idMovimiento"];
                    auxMovimiento.Id_Tipo = datos.buscarTipoMovimiento(auxTipo).ToString();
                    auxMovimiento.Persona = datos.buscarChofer(auxDni).ToString();
                    auxMovimiento.Interno = (int)datos.Lector["interno"];
                    auxMovimiento.Furgon = (int)datos.Lector["idFurgon"];
                    auxMovimiento.Cliente = datos.buscarCliente(auxCliente).ToString();
                    auxMovimiento.Fecha = (DateTime)datos.Lector["fecha"];
                    auxMovimiento.Destino = (string)datos.Lector["destino"];
                    auxMovimiento.Observaciones = (string)datos.Lector["observaciones"];

                    listaMovimientos.Add(auxMovimiento);
                }

                return listaMovimientos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }

        public void agregarMovimiento(Movimiento nvMv) 
        {
            AccesoDatos datos = new AccesoDatos();
            int dni, idCliente;

            if (nvMv.Persona != "SIN CHOFER ASIGNADO")
                dni = datos.buscarDniFull(nvMv.Persona);
            else {dni = 0;}

            if (nvMv.Cliente != "")
                idCliente = datos.buscarIdCliente(nvMv.Cliente);
            else { idCliente = 0; }

            try
            {
                datos.setearConsulta("INSERT INTO cantarini_control.dbo.movimientos(idTipo, dni, interno, idFurgon, idCliente, fecha, destino, observaciones) VALUES (" + nvMv.Id_Tipo + ", " + dni + ", " + nvMv.Interno + ", " + nvMv.Furgon + ", '" + idCliente + "', convert(datetime, getdate()), '" + nvMv.Destino + "', '" + nvMv.Observaciones + "');");
                datos.ejecutarAccion();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }

        public void modificarMovimiento(Movimiento mdMv) 
        { 
            AccesoDatos datos = new AccesoDatos();
            int dni, idCliente;
            idCliente = datos.buscarIdCliente(mdMv.Cliente);

            if (mdMv.Persona != "SIN CHOFER ASIGNADO")
            {
                dni = datos.buscarDniFull(mdMv.Persona);
            }
            else { dni = 0; }


            try
            {
                datos.setearConsulta("UPDATE cantarini_control.dbo.movimientos SET dni=" + dni + ", interno=" + mdMv.Interno + ", idFurgon=" + mdMv.Furgon + ", idCliente=" + idCliente + ", observaciones='" + mdMv.Observaciones.ToUpper() + "' WHERE idMovimiento=" + mdMv.Id_Movimiento + ";");
                datos.ejecutarAccion();
            }
            catch(Exception ex) { throw ex; }
            finally { datos.cerrarConexion(); }
        }
    }
}
