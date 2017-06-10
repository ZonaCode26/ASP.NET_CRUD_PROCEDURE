using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class tb_herramienta
    {
        public string idHer { get; set; }
        public string desHer { get; set; }
        public int idprov { get; set; }
        public decimal preUni { get; set; }
        public int stock { get; set; }
    }
}
