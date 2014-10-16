using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data;
namespace DAO
{
    public class DAOEntradas
    {
        ConexionDatos conexion = new ConexionDatos();

        public List<Entrada> TraerEntradasxFiesta(int ID)
        {
            conexion.Conectar();
            List<Entrada> lista = new List<Entrada>();
            string sentencia = "select * from Entradas1 where FiestaID=" + ID + "";
            DataTable tabla = conexion.LeerDatos(sentencia);
            foreach (DataRow dr in tabla.Rows)
            {
                Entrada oEntrada = new Entrada(Convert.ToInt32(dr["DNI"]), dr["apellido"].ToString(), dr["nombre"].ToString(), Convert.ToInt32(dr["nro"]), Convert.ToInt32(dr["usado"]), Convert.ToInt32(dr["FiestaID"]), dr["nombrefiesta"].ToString(), Convert.ToDecimal(dr["precio"]));
                oEntrada.Id = Convert.ToInt32(dr["ID"]);
                lista.Add(oEntrada);
            }
            conexion.Desconectar();
            return lista;
        }

        public List<Entrada> TraerEntradasFiestaxDNI(int ID, int dni)
        {
            conexion.Conectar();
            List<Entrada> lista = new List<Entrada>();
            string sentencia = "select * from Entradas1 where FiestaID=" + ID + " and DNI like '%" + dni + "%'";
            DataTable tabla = conexion.LeerDatos(sentencia);
            foreach (DataRow dr in tabla.Rows)
            {
                Entrada oEntrada = new Entrada(Convert.ToInt32(dr["DNI"]), dr["apellido"].ToString(), dr["nombre"].ToString(), Convert.ToInt32(dr["nro"]), Convert.ToInt32(dr["usado"]), Convert.ToInt32(dr["FiestaID"]), dr["nombrefiesta"].ToString(), Convert.ToDecimal(dr["precio"]));
                oEntrada.Id = Convert.ToInt32(dr["ID"]);
                lista.Add(oEntrada);
            }
            conexion.Desconectar();
            return lista;
        }

        public List<Entrada> TraerEntradasFiestaxApellido(int ID, string apell)
        {
            conexion.Conectar();
            List<Entrada> lista = new List<Entrada>();
            string sentencia = "select * from Entradas1 where FiestaID=" + ID + " and apellido like '%" + apell + "%'";
            DataTable tabla = conexion.LeerDatos(sentencia);
            foreach (DataRow dr in tabla.Rows)
            {
                Entrada oEntrada = new Entrada(Convert.ToInt32(dr["DNI"]), dr["apellido"].ToString(), dr["nombre"].ToString(), Convert.ToInt32(dr["nro"]), Convert.ToInt32(dr["usado"]), Convert.ToInt32(dr["FiestaID"]), dr["nombrefiesta"].ToString(), Convert.ToDecimal(dr["precio"]));
                oEntrada.Id = Convert.ToInt32(dr["ID"]);
                lista.Add(oEntrada);
            }
            conexion.Desconectar();
            return lista;
        }

        public List<Entrada> TraerEntradasFiestaxNum(int ID, int num)
        {
            conexion.Conectar();
            List<Entrada> lista = new List<Entrada>();
            string sentencia = "select * from Entradas1 where FiestaID=" + ID + " and nro like '%" + num + "%'";
            DataTable tabla = conexion.LeerDatos(sentencia);
            foreach (DataRow dr in tabla.Rows)
            {
                Entrada oEntrada = new Entrada(Convert.ToInt32(dr["DNI"]), dr["apellido"].ToString(), dr["nombre"].ToString(), Convert.ToInt32(dr["nro"]), Convert.ToInt32(dr["usado"]), Convert.ToInt32(dr["FiestaID"]), dr["nombrefiesta"].ToString(), Convert.ToDecimal(dr["precio"]));
                oEntrada.Id = Convert.ToInt32(dr["ID"]);
                lista.Add(oEntrada);
            }
            conexion.Desconectar();
            return lista;
        }

        public List<Entrada> TraerEntradaFiestaxID(int ID)
        {
            conexion.Conectar();
            List<Entrada> lista = new List<Entrada>();
            string sentencia = "select * from Entradas1 where ID=" + ID + "";
            DataTable tabla = conexion.LeerDatos(sentencia);
            foreach (DataRow dr in tabla.Rows)
            {
                Entrada oEntrada = new Entrada(Convert.ToInt32(dr["DNI"]), dr["apellido"].ToString(), dr["nombre"].ToString(), Convert.ToInt32(dr["nro"]), Convert.ToInt32(dr["usado"]), Convert.ToInt32(dr["FiestaID"]), dr["nombrefiesta"].ToString(), Convert.ToDecimal(dr["precio"]));
                oEntrada.Id = Convert.ToInt32(dr["ID"]);
                lista.Add(oEntrada);
            }
            conexion.Desconectar();
            return lista;
        }

        public void MarcarEntrada(int ID)
        {
            conexion.Conectar();
            string sentencia = "update Entradas1 set usado = 1 where ID=" + ID + "";
            conexion.EjecutarSQL(sentencia);
            conexion.Desconectar();
        }

     

        public List<Entrada> TraerEntradasxDNI(int DNI)
        {
            conexion.Conectar();
            List<Entrada> lista = new List<Entrada>();
            string sentencia = "select * from Entradas1 where DNI like '%" + DNI + "%'";
            DataTable tabla = conexion.LeerDatos(sentencia);
            foreach (DataRow dr in tabla.Rows)
            {
                Entrada oEntrada = new Entrada(Convert.ToInt32(dr["DNI"]), dr["apellido"].ToString(), dr["nombre"].ToString(), Convert.ToInt32(dr["nro"]), Convert.ToInt32(dr["usado"]), Convert.ToInt32(dr["FiestaID"]), dr["nombrefiesta"].ToString(), Convert.ToDecimal(dr["precio"]));
                oEntrada.Id = Convert.ToInt32(dr["ID"]);
                lista.Add(oEntrada);
            }
            conexion.Desconectar();
            return lista;
        }


        public List<Entrada> TraerEntradasxNRO(int nro)
        {
            conexion.Conectar();
            List<Entrada> lista = new List<Entrada>();
            string sentencia = "select * from Entradas1 where nro like '%" + nro + "%'";
            DataTable tabla = conexion.LeerDatos(sentencia);
            foreach (DataRow dr in tabla.Rows)
            {
                Entrada oEntrada = new Entrada(Convert.ToInt32(dr["DNI"]), dr["apellido"].ToString(), dr["nombre"].ToString(), Convert.ToInt32(dr["nro"]), Convert.ToInt32(dr["usado"]), Convert.ToInt32(dr["FiestaID"]), dr["nombrefiesta"].ToString(), Convert.ToDecimal(dr["precio"]));
                oEntrada.Id = Convert.ToInt32(dr["ID"]);
                lista.Add(oEntrada);
            }
            conexion.Desconectar();
            return lista;
        }


        public List<Entrada> TraerEntradasxApellido(string Apellido)
        {
            conexion.Conectar();
            List<Entrada> lista = new List<Entrada>();
            string sentencia = "select * from Entradas1 where apellido like '%" + Apellido + "%'";
            DataTable tabla = conexion.LeerDatos(sentencia);
            foreach (DataRow dr in tabla.Rows)
            {
                Entrada oEntrada = new Entrada(Convert.ToInt32(dr["DNI"]), dr["apellido"].ToString(), dr["nombre"].ToString(), Convert.ToInt32(dr["nro"]), Convert.ToInt32(dr["usado"]), Convert.ToInt32(dr["FiestaID"]), dr["nombrefiesta"].ToString(), Convert.ToDecimal(dr["precio"]));
                oEntrada.Id = Convert.ToInt32(dr["ID"]);
                lista.Add(oEntrada);
            }
            conexion.Desconectar();
            return lista;
        }

        public List<Entrada> TraerEntradasTodas()
        {
            conexion.Conectar();
            List<Entrada> lista = new List<Entrada>();
            string sentencia = "select * from Entradas1";
            DataTable tabla = conexion.LeerDatos(sentencia);
            foreach (DataRow dr in tabla.Rows)
            {
                Entrada oEntrada = new Entrada(Convert.ToInt32(dr["DNI"]), dr["apellido"].ToString(), dr["nombre"].ToString(), Convert.ToInt32(dr["nro"]), Convert.ToInt32(dr["usado"]), Convert.ToInt32(dr["FiestaID"]), dr["nombrefiesta"].ToString(), Convert.ToDecimal(dr["precio"]));
                oEntrada.Id = Convert.ToInt32(dr["ID"]);
                lista.Add(oEntrada);
            }
            conexion.Desconectar();
            return lista;
        }



        public void IngresarEntrada(Entrada oEntrada)
        {

            string sentencia = "insert into Entradas1(DNI, apellido, nombre,nro,usado,fiestaID,nombrefiesta, precio) values(" + oEntrada.DNI + ",'" + oEntrada.APELLIDO + "','" + oEntrada.NOMBRE + "'," + oEntrada.NRO + "," + oEntrada.USADA + "," + oEntrada.FiestaID1 + ",'" + oEntrada.Nombrefiesta + "', " + Convert.ToInt32(oEntrada.Precio) + ")";
            conexion.Conectar();
            conexion.EjecutarSQL(sentencia);
            conexion.Desconectar();
        }

        


        public int TraerUltimoNro()
        {
            int id = 0;
            try
            {
                string sentencia = " select MAX(nro) as nro from Entradas1";

                conexion.Conectar();
                DataTable tabla = conexion.LeerDatos(sentencia);
                foreach (DataRow dr in tabla.Rows)
                {
                    id = Convert.ToInt32(dr["nro"]);
                }
                conexion.Desconectar();
            }
            catch
            {
                return 0;
            }


            return id;

        }

        public void ModificarEntrada(Entrada oEntrada)
        {
            string sentencia = "update Entradas1 set DNI=" + oEntrada.DNI + ", nombre='" + oEntrada.NOMBRE + "',apellido='" + oEntrada.APELLIDO + "', usado=" + oEntrada.USADA + ", nro= "+oEntrada.NRO+" where ID = " + oEntrada.Id + "";
            conexion.Conectar();
            conexion.EjecutarSQL(sentencia);
            conexion.Desconectar();
        }

        public void AnularEntrada(int id)
        {
            string sentencia = " update Entradas1 set usado=2 where ID=" + id + "";
            conexion.Conectar();
            conexion.EjecutarSQL(sentencia);
            conexion.Desconectar();
        }
    }
}
