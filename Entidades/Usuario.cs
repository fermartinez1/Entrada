using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Usuario
    {
        int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        string contraseña;

        public string Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        }
        int nivel;

        public int Nivel
        {
            get { return nivel; }
            set { nivel = value; }
        }


        public Usuario(string nom, string contra, int niv)
        {
            this.nombre = nom;
            this.contraseña = contra;
            this.nivel = niv;
        }
    }
}
