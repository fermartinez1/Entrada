using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data;
namespace DAO
{
    public class DAOFiestas
    {
        ConexionDatos conexion = new ConexionDatos();
        Fiesta oFiesta1;
        public List<Fiesta> TraerFiestas()
        {
            conexion.Conectar();
            List<Fiesta> lista = new List<Fiesta>();
            string sentencia = "select * from Fiestas";
            DataTable tabla = conexion.LeerDatos(sentencia);
            foreach (DataRow dr in tabla.Rows)
            {
                Fiesta oFiesta = new Fiesta(dr["colegios"].ToString(), Convert.ToDecimal(dr["precio"]), dr["cursos"].ToString(), dr["salon"].ToString(), (dr["fecha"].ToString()));
                oFiesta.Id = Convert.ToInt32(dr["ID"]);

                lista.Add(oFiesta);
            }
            conexion.Desconectar();
            return lista;
        }

        public Fiesta TraerFiestasxID(int id)
        {
            conexion.Conectar();
            string sentencia = "select * from Fiestas where ID=" + id + "";
            DataTable tabla = conexion.LeerDatos(sentencia);
            foreach (DataRow dr in tabla.Rows)
            {
                oFiesta1 = new Fiesta(dr["colegios"].ToString(), Convert.ToDecimal(dr["precio"]), dr["cursos"].ToString(), dr["salon"].ToString(), (dr["fecha"].ToString()));
                oFiesta1.Id = Convert.ToInt32(dr["ID"]);

            }
            conexion.Desconectar();
            return oFiesta1;
        }

        public List<Fiesta> TraerFiestasxColegio(string colegio)
        {
            conexion.Conectar();
            List<Fiesta> lista = new List<Fiesta>();
            string sentencia = "select * from Fiestas where colegios like '%" + colegio + "%'";
            DataTable tabla = conexion.LeerDatos(sentencia);
            foreach (DataRow dr in tabla.Rows)
            {
                Fiesta oFiesta = new Fiesta(dr["colegios"].ToString(), Convert.ToDecimal(dr["precio"]), dr["cursos"].ToString(), dr["salon"].ToString(), (dr["fecha"].ToString()));
                oFiesta.Id = Convert.ToInt32(dr["ID"]);

                lista.Add(oFiesta);
            }
            conexion.Desconectar();
            return lista;
        }

        public List<Fiesta> TraerFiestasxFecha(string fecha)
        {
            conexion.Conectar();
            List<Fiesta> lista = new List<Fiesta>();
            string sentencia = "select * from Fiestas where fecha ='" + fecha + "'";
            DataTable tabla = conexion.LeerDatos(sentencia);
            foreach (DataRow dr in tabla.Rows)
            {
                Fiesta oFiesta = new Fiesta(dr["colegios"].ToString(), Convert.ToDecimal(dr["precio"]), dr["cursos"].ToString(), dr["salon"].ToString(), (dr["fecha"].ToString()));
                oFiesta.Id = Convert.ToInt32(dr["ID"]);

                lista.Add(oFiesta);
            }
            conexion.Desconectar();
            return lista;
        }


        public void InsertarFiesta(Fiesta oFiesta)
        {
            string sentencia = "insert into Fiestas (colegios,salon,cursos,fecha,precio) values ('" + oFiesta.Colegios + "','" + oFiesta.Salon + "','" + oFiesta.Cursos + "','" + oFiesta.Fecha + "'," + oFiesta.Precio + ")";
            conexion.Conectar();
            conexion.EjecutarSQL(sentencia);
            conexion.Desconectar();
        }

        public void EliminarFiesta(int id)
        {
            string sentencia = "delete from Fiestas where ID=" + id + "";
            conexion.Conectar();
            conexion.EjecutarSQL(sentencia);
            conexion.Desconectar();
        }

        public void ModificarFiesta(Fiesta oFiesta)
        {
            string sentencia = "update Fiestas set colegios='" + oFiesta.Colegios + "', cursos='" + oFiesta.Cursos + "', fecha='" + oFiesta.Fecha + "', salon='" + oFiesta.Salon + "', precio='" + oFiesta.Precio + "' where ID = " + oFiesta.Id + "";
            conexion.Conectar();
            conexion.EjecutarSQL(sentencia);
            conexion.Desconectar();
        }

    }
}
