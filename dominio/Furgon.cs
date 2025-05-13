using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Furgon
    {
        public int Interno { get; set; }
        public string Empresa { get; set; }
        public string Dominio { get; set; }

        public bool Activo { get; set; }
        public bool OK_Taller {  get; set; }
    }
}
