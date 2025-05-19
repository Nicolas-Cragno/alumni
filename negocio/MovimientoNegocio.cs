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
        const string db_tipos_movimientos = "cantarini_control.dbo.tipos_movimientos";

        public List<string> tiposMovimientos()
        {
            List<string> listaMovimientos = new List<string>();
            AccesoDatos datos = new AccesoDatos();

            string camposListaMovimientos = "SELECT nombre";
            string database = " FROM " + db_tipos_movimientos + ";";
            string queryMovimientos = camposListaMovimientos + database;

            try
            {
                datos.setearConsulta(queryMovimientos);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    string auxNombre;

                    auxNombre = (string)datos.Lector["nombre"];

                    listaMovimientos.Add(auxNombre);
                }

                return listaMovimientos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }

        public List<Movimiento> listarMovimientos()
        {
            List<Movimiento> listaMovimientos = new List<Movimiento>();
            AccesoDatos datos = new AccesoDatos();

            string campoListaMovimientos = "SELECT idMovimiento, idTipo, dni, interno, idFurgon, idCliente, fecha, destino, observaciones, okPanico, okCorte, okReporte, okDesenganche, okCabina, okAntiv, okFurgon";
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
                    auxMovimiento.Observaciones = (string)datos.Lector["observaciones"].ToString();
                    auxMovimiento.OK_Panico = (bool)datos.Lector["okPanico"];
                    auxMovimiento.OK_Corte = (bool)datos.Lector["okCorte"];
                    auxMovimiento.OK_Reporte = (bool)datos.Lector["okReporte"];
                    auxMovimiento.OK_Desenganche = (bool)datos.Lector["okDesenganche"];
                    auxMovimiento.OK_Cabina = (bool)datos.Lector["okCabina"];
                    auxMovimiento.OK_Antiv = (bool)datos.Lector["okAntiv"];
                    auxMovimiento.OK_Furgon = (bool)datos.Lector["okFurgon"];
                    /*
                     */

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
            int dni, idCliente, idMovimiento;

            if(nvMv.Id_Tipo != "SIN ASIGNAR")
                idMovimiento = datos.buscarIdTipoMovimiento(nvMv.Id_Tipo);
            else { idMovimiento = 0 ; }
            if (nvMv.Persona != "SIN CHOFER ASIGNADO")
                dni = datos.buscarDniFull(nvMv.Persona);
            else { dni = 0; }

            if (nvMv.Cliente != "" || nvMv.Cliente != null)
                idCliente = datos.buscarIdCliente(nvMv.Cliente);
            else { idCliente = 0; }

            try
            {
                datos.setearConsulta("INSERT INTO cantarini_control.dbo.movimientos(idTipo, dni, interno, idFurgon, idCliente, fecha, destino, observaciones) VALUES (" + idMovimiento + ", " + dni + ", " + nvMv.Interno + ", " + nvMv.Furgon + ", '" + idCliente + "', convert(datetime, getdate()), '" + nvMv.Destino + "', '" + nvMv.Observaciones + "');");
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
            int okPanico = datos.numerarBool(mdMv.OK_Panico);
            int okCorte = datos.numerarBool(mdMv.OK_Corte);
            int okReporte = datos.numerarBool(mdMv.OK_Reporte);
            int okDesenganche = datos.numerarBool(mdMv.OK_Desenganche);
            int okCabina = datos.numerarBool(mdMv.OK_Cabina);
            int okAntiv = datos.numerarBool(mdMv.OK_Antiv);
            int okFurgon = datos.numerarBool(mdMv.OK_Furgon);

            if (mdMv.Persona != "SIN CHOFER ASIGNADO")
            {
                dni = datos.buscarDniFull(mdMv.Persona);
            }
            else { dni = 0; }


            try
            {
                string database = "UPDATE cantarini_control.dbo.movimientos SET ";
                string values = "dni=" + dni + ", interno=" + mdMv.Interno + ", idFurgon=" + mdMv.Furgon + ", idCliente=" + idCliente + ", observaciones='" + mdMv.Observaciones.ToUpper() + "', okPanico=" + okPanico + ", okCorte=" + okCorte + ", okReporte=" + okReporte + ", okDesenganche=" + okDesenganche + ", okCabina=" + okCabina + ", okAntiv=" + okAntiv + ", okFurgon=" + okFurgon;
                string where = " WHERE idMovimiento=" + mdMv.Id_Movimiento + ";";
                datos.setearConsulta(database + values + where);
                datos.ejecutarAccion();
            }
            catch(Exception ex) { throw ex; }
            finally { datos.cerrarConexion(); }
        }
    }
}
