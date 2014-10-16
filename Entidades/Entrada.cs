using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Entrada
    {
        string nombre;
        string apellido;
        int usada;
        int dni;
        int nro;
        int id;
        string nombrefiesta;

      
        int FiestaID;
        decimal precio;



        public int NRO
        {
            get { return nro; }
            set { nro = value; }
        }
        public string NOMBRE
        {
            get { return nombre; }
            set { nombre = value; }
        }



        public string APELLIDO
        {
            get { return apellido; }
            set { apellido = value; }
        }


        public int DNI
        {
            get { return dni; }
            set { dni = value; }
        }
        public string Nombrefiesta
        {
            get { return nombrefiesta; }
            set { nombrefiesta = value; }
        }
        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }


        public int USADA
        {
            get { return usada; }
            set { usada = value; }
        }

        public int FiestaID1
        {
            get { return FiestaID; }
            set { FiestaID = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Entrada(int dn, string ape, string nom, int nr, int us, int fiest,string nombfie, decimal precio)
        {
            this.dni = dn;
            this.apellido = ape;
            this.nombre = nom;
            this.nro = nr;
            this.usada = us;
            this.FiestaID = fiest;
            this.precio = precio;
            this.nombrefiesta = nombfie;
        }

        public Entrada()
        { }
    }
}
