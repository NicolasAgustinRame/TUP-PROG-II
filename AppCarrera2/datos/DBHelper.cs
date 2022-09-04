using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AppCarrera2.datos
{
    internal class DBHelper
    {
        private SqlConnection conexion = new SqlConnection(Properties.Resources.candenaConexion);
        private SqlCommand comando = new SqlCommand();

        private void Conectar()
        {
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
        }

        public void Desconectar()
        {
            conexion.Close();
        }

        public DataTable consultarBD(string strSQL)
        {
            DataTable tabla = new DataTable();
            Conectar();
            comando.CommandText = strSQL;
            tabla.Load(comando.ExecuteReader());
            Desconectar();
            return tabla;
        }

    }
}
