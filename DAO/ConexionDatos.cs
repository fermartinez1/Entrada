using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class ConexionDatos
    {
        SqlConnection conexion = new SqlConnection("Data Source=Fernando;Initial Catalog=Fiesta;Integrated Security=True");
        
        public void Conectar()
        {
            try
            {
                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                }
            }
            catch {
                throw new Exception("No se puede conectar con la base de datos");
            }
        }

        public void Desconectar()
        {
            try
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            catch
            {
                throw new Exception("Error al cerrar conexión con la base de datos");
            }
        }

        public DataTable LeerDatos(string sentencia)
        {
            try
            {
                DataTable tabla = new DataTable();
                SqlCommand comando = new SqlCommand(sentencia, conexion);
                Conectar();
                SqlDataReader reader = comando.ExecuteReader();
                tabla.Load(reader);
                Desconectar();
                return tabla;
            }
            catch
            {
                throw new Exception("Error al leer la base de datos");
            }
        }

        public void EjecutarSQL(string sentencia)
        {
            try
            {
                SqlCommand comando = new SqlCommand(sentencia, conexion);
                Conectar();
                comando.ExecuteNonQuery();
                Desconectar();
            }
            catch
            {
                throw new Exception("Error al ejecutar sentencia en la base de datos");
            }
        }

        public Object EjecutarScalar(string sentencia)
        {
            try
            {
                SqlCommand comando = new SqlCommand(sentencia, conexion);
                Conectar();
                Object respuesta = comando.ExecuteScalar();
                Desconectar();
                return respuesta;
            }
            catch
            {
                throw new Exception("Error al ejecutar sentencia en la base de datos");
            }
        }

        public void EjecutarSelectProcedure(string nombreProc, SqlParameter[] Param)
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = nombreProc;
                comando.Connection = conexion;
                foreach (SqlParameter p in Param)
                {
                    comando.Parameters.Add(p);
                }
                Conectar();
                object valor = comando.ExecuteScalar();
                Desconectar();
            }
            catch
            {
                throw new Exception("Error al ejecutar sentencia en la base de datos");
            }
        }

    }
}