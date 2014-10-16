using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Colegio
    {
        int id;
        string nombre;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Colegio(string nom)
        {
            this.nombre = nom;
        }
    }
}
