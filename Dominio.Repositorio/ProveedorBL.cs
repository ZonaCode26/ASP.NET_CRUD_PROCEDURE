using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Infraestructura.Data.Sql;
using Dominio.Entidades;

using System.Data.SqlClient;

namespace Dominio.Repositorio
{
    public class ProveedorBL
    {
        ProveedorDAL proveedor = new ProveedorDAL();

        public List<tb_proveedor> listaProveedor()
        {
            return proveedor.listaProveedor();

        }
        

    }
}
