using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data.SqlClient;
using System.Data;
using Dominio.Entidades;

namespace Infraestructura.Data.Sql
{
    public class ProveedorDAL
    {
        conexionSQL conecta = new conexionSQL();

        public List<tb_proveedor> listaProveedor() {

            List<tb_proveedor> lista = new List<tb_proveedor>();


           SqlCommand cmd = new SqlCommand("USP_LISTAPROVEEDOR",conecta.CN);
            cmd.CommandType = CommandType.StoredProcedure;
            conecta.CN.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read()) {

                tb_proveedor reg = new tb_proveedor();
                reg.idprov = dr.GetInt32(0);
                reg.nomprov = dr.GetString(1);

                lista.Add(reg);
            }
            conecta.CN.Close();
            dr.Close();

            return lista;
        }

    }
}
