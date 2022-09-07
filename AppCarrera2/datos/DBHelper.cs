using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using AppCarrera2.domino;

namespace AppCarrera2.datos
{
    internal class DBHelper
    {
        private SqlConnection conexion = new SqlConnection(Properties.Resources.candenaConexion);
        private SqlCommand comando = new SqlCommand();

        private void Comando(string SP)
        {
            
            comando.Connection = conexion;
            comando.CommandText = SP;
            comando.CommandType = System.Data.CommandType.StoredProcedure;
        }

        
        public DataTable consultarBD(string strSQL)
        {
            DataTable tabla = new DataTable();
            conexion.Open();
            Comando(strSQL);
            comando.CommandText = strSQL;
            tabla.Load(comando.ExecuteReader());
            conexion.Close();
            return tabla;
        }

        public bool ConfirmarCarrera(Carrera carrera)
        {
            bool ok = true;
            SqlTransaction trs = null;
            try
            {
                conexion.Open();
                trs = conexion.BeginTransaction();  
                SqlCommand cmdCarrera = new SqlCommand("SP_ADD_CARRERA" , conexion, trs);
                cmdCarrera.CommandType = CommandType.StoredProcedure;
                SqlParameter parametro = new SqlParameter("@new_codCarrera", SqlDbType.Int);
                parametro.Direction = ParameterDirection.Output;
                cmdCarrera.Parameters.Add(parametro);
                cmdCarrera.ExecuteNonQuery();

                int codCarrera = Convert.ToInt32(parametro.Value);
                SqlCommand cmdDet = new SqlCommand("SP_ADD_DET", conexion, trs);
                cmdDet.CommandType = CommandType.StoredProcedure;

                for (int i = 0; i < carrera.DetallesCarreras.Count; i++)
                {
                    cmdDet.Parameters.Clear();
                    cmdDet.Parameters.AddWithValue("@anioCursado", carrera.DetallesCarreras[i].AnioCursado);
                    cmdDet.Parameters.AddWithValue("@cuatrimestre", carrera.DetallesCarreras[i].Cuatrimestre);
                    cmdDet.Parameters.AddWithValue("@codAsignatura", carrera.DetallesCarreras[i].Materia.CodAsignatura);
                    cmdDet.Parameters.AddWithValue("codCarrera", codCarrera);
                }
                trs.Commit();
            }
            catch (Exception)
            {
                trs.Rollback();
                ok = false;
            }
            finally 
            {
                if(conexion.State == ConnectionState.Open)
                 conexion.Close();
            }
            return ok;
        }

        public int Alta(string SPName, Carrera carrera)
        {
            int codCarrera;
            conexion.Open();
            Comando(SPName);
            comando.Parameters.AddWithValue("@nombreTitulo", carrera.NombreTitulo);
            SqlParameter prm = new SqlParameter("@new_codCarrera" , SqlDbType.Int);
            prm.Direction = ParameterDirection.Output;
            comando.Parameters.Add(prm);
            comando.ExecuteNonQuery();

            codCarrera = Convert.ToInt32(prm.Value);

            conexion.Close();
            return codCarrera;
        }

       

    }
}
