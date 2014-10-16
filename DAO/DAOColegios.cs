using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data;
namespace DAO
{
    public class DAOColegios
    {
        ConexionDatos Conexion = new ConexionDatos();

        public List<Colegio> TraerColegios()
        {
            Conexion.Conectar();
            List<Colegio> lista = new List<Colegio>();
            string sentencia = "select * from Colegio";
            DataTable tabla = Conexion.LeerDatos(sentencia);
            foreach (DataRow dr in tabla.Rows)
            {
                Colegio oColegio = new Colegio(dr["nombre"].ToString());
                oColegio.Id = Convert.ToInt32(dr["ID"]);
                lista.Add(oColegio);
            }
            Conexion.Desconectar();
            return lista;
        }

        public void InsertarColegio(string nombre)
        {
            string sentencia = "insert into Colegio (nombre) values ('"+nombre+"')";
            Conexion.Conectar();
            Conexion.EjecutarSQL(sentencia);
            Conexion.Desconectar();
        }

        public void ModificarColegio(string nombre, int id)
        {
            string sentencia = "update Colegio set nombre = '" + nombre + "' where id = " + id + "";
            Conexion.Conectar();
            Conexion.EjecutarSQL(sentencia);
            Conexion.Desconectar();
        }

        public void EliminarColegio(int id)
        {
            string sentencia = "delete from Colegio where id = " + id + "";
            Conexion.Conectar();
            Conexion.EjecutarSQL(sentencia);
            Conexion.Desconectar();
        }
    }
}
