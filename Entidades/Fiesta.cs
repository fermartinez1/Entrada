using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Fiesta
    {
        int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        string colegios;

        public string Colegios
        {
            get { return colegios; }
            set { colegios = value; }
        }
        decimal precio;

        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        string cursos;

        public string Cursos
        {
            get { return cursos; }
            set { cursos = value; }
        }
        string salon;

        public string Salon
        {
            get { return salon; }
            set { salon = value; }
        }
        string fecha;

        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }



        public Fiesta(string col, decimal prec, string cur, string sal, string fec)
        {
            this.colegios = col;
            this.precio = prec;
            this.cursos = cur;
            this.salon = sal;
            this.fecha = fec;
        }

        public Fiesta()
        { }

    }

}
