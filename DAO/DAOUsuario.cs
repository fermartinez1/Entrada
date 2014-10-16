using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class DAOUsuario
    {
        ConexionDatos Conexion = new ConexionDatos();
        DataTable tabla = new DataTable();

        public List<Usuario> TraerUsuarios()
        {
            List<Usuario> Lista = new List<Usuario>();
            string sentencia = "select * from Usuarios";
            Conexion.Conectar();
            tabla = Conexion.LeerDatos(sentencia);
            foreach (DataRow dr in tabla.Rows)
            {                
                Usuario oUsuario = new Usuario(dr["usuario"].ToString(), dr["contraseña"].ToString(), Convert.ToInt32(dr["nivel"]));
                oUsuario.Id = Convert.ToInt32(dr["id"]);
                Lista.Add(oUsuario);
            }
            Conexion.Desconectar();
            return Lista;
        }
    }
}
