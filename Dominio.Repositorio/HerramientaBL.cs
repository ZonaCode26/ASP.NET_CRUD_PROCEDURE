using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dominio.Entidades;
using Infraestructura.Data.Sql;
using System.Data.SqlClient;



namespace Dominio.Repositorio
{
    public class HerramientaBL
    {
        HerramientaDAL herrramienta = new HerramientaDAL();


        public List<tb_herramienta> listadoHerramienta()
        {
            return herrramienta.listadoHerramienta();
        }


        public string AgregarHerramienta(tb_herramienta reg) {

            return herrramienta.AgregarHerramienta(reg);
        }



        public string ActualizarHerramienta(tb_herramienta reg)
        {

            return herrramienta.ActualizarHerramienta(reg);
        }

    }
}
