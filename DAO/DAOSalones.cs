using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data;
namespace DAO
{
    public class DAOSalones
    {
        ConexionDatos Conexion = new ConexionDatos();

        public List<Salon> TraerSalones()
        {
            Conexion.Conectar();
            List<Salon> lista = new List<Salon>();
            string sentencia = "select * from Salones";
            DataTable tabla = Conexion.LeerDatos(sentencia);
            foreach (DataRow dr in tabla.Rows)
            {
                Salon oSalon = new Salon(dr["nombre"].ToString(), Convert.ToInt32(dr["capacidad"]));
                oSalon.Id = Convert.ToInt32(dr["ID"]);
                lista.Add(oSalon);
            }
            Conexion.Desconectar();
            return lista;
        }

        public void InsertarSalon(string nombre, int capacidad)
        {
            string sentencia = "insert into Salones (nombre, capacidad) values ('" + nombre + "',"+capacidad+")";
            Conexion.Conectar();
            Conexion.EjecutarSQL(sentencia);
            Conexion.Desconectar();
        }

        public void ModificarSalon(string nombre, int capacidad, int id)
        {
            string sentencia = "update Salones set nombre='" + nombre + "', capacidad=" + capacidad + " where ID=" + id + "";
            Conexion.Conectar();
            Conexion.EjecutarSQL(sentencia);
            Conexion.Desconectar();
        }


        public void EliminarSalon(int id)
        {
            string sentencia = "delete from Salones where ID="+id+"";
            Conexion.Conectar();
            Conexion.EjecutarSQL(sentencia);
            Conexion.Desconectar();
        }
    }
}
