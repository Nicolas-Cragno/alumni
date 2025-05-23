﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using negocio;

namespace negocio
{
    public class FurgonNegocio
    {
        const string db_furgones = "cantarini_control.dbo.furgones";

        public List<Furgon> listarFurgones()
        {
            List<Furgon> listaFurgones = new List<Furgon>();
            AccesoDatos datos = new AccesoDatos();

            string campoListaFurgones = "SELECT idFurgon, IdEmpresa, dominio, activo, okTaller, observaciones";
            string database = " FROM " + db_furgones + ";";
            string queryFurgones = campoListaFurgones + database;

            try
            {
                datos.setearConsulta(queryFurgones);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Furgon auxFurgon = new Furgon();
                    int auxEmpresa = (int)datos.Lector["idEmpresa"];

                    auxFurgon.Interno = (int)datos.Lector["idFurgon"];
                    auxFurgon.Empresa = datos.buscarEmpresa(auxEmpresa);
                    auxFurgon.Dominio = (string)datos.Lector["dominio"];
                    auxFurgon.Activo = (bool)datos.Lector["activo"];
                    auxFurgon.OK_Taller = (bool)datos.Lector["okTaller"];
                    auxFurgon.Observaciones = (string)datos.Lector["observaciones"].ToString();

                    listaFurgones.Add(auxFurgon);
                }

                return listaFurgones;
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

        public List<int> listarInternos()
        {
            List<int> listaInternos = new List<int>();
            AccesoDatos datos = new AccesoDatos();

            string campoListaInternos = "SELECT idFurgon";
            string database = " FROM " + db_furgones + ";";
            string queryInternos = campoListaInternos + database;

            try
            {
                datos.setearConsulta(queryInternos);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    int auxInterno = (int)datos.Lector["idFurgon"];

                    listaInternos.Add(auxInterno);
                }

                return listaInternos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }

        public void agregar(Furgon nvFg)
        {
            AccesoDatos datos = new AccesoDatos();

            int idEmpresa = datos.buscarIdEmpresa(nvFg.Empresa);

            try
            {
                datos.setearConsulta("INSERT INTO cantarini_control.dbo.furgones (idFurgon, idEmpresa, dominio, observaciones) VALUES (" + nvFg.Interno + ", " + idEmpresa + ", '" + nvFg.Dominio + "', '" + nvFg.Observaciones + "');");
                datos.ejecutarAccion();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void modificar(Furgon mdFg) 
        {
            AccesoDatos datos = new AccesoDatos();
            int idEmpresa = datos.buscarIdEmpresa(mdFg.Empresa);
            int activo = datos.numerarBool(mdFg.Activo);
            int okTaller = datos.numerarBool(mdFg.OK_Taller);

            try
            {
                datos.setearConsulta("UPDATE furgones SET idEmpresa=" + idEmpresa + ", dominio='" + mdFg.Dominio.ToUpper() + "', activo=" + activo + ", okTaller=" + okTaller + ", observaciones='" + mdFg.Observaciones.ToUpper() + "' WHERE idFurgon=" + mdFg.Interno + ";");
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }
    }
}
