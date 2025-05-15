using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Movimiento
    {
        public int Id_Movimiento { get; set; }
        public string Id_Tipo { get; set; }
        public string Persona { get; set; }
        public int Interno { get; set; }
        public int Furgon { get; set; }
        public string Cliente { get; set; }
        public DateTime Fecha { get; set; }
        public string Destino { get; set; }
        public string Observaciones { get; set; }
        public bool OK_Panico { get; set; }
        public bool OK_Corte { get; set; }
        public bool OK_Reporte {  get; set; }
        public bool OK_Desenganche { get; set; }
        public bool OK_Cabina { get; set; }
        public bool OK_Antiv {  get; set; }
        public bool OK_Furgon { get; set; }
    }
}
