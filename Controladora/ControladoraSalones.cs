using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using Entidades;

namespace Controladora
{
    public class ControladoraSalones
    {
        DAOSalones DaoSalones = new DAOSalones();

        public bool VerificarExistenciaI(string nombre)
        {
            List<Salon> lista = DaoSalones.TraerSalones();
            foreach (Salon aux in lista)
            {
                if (aux.Nombre == nombre)
                {
                        return true;
                }
            }
            return false;
        }

        public bool VerificarExistenciaM(string nombre, int capacidad)
        {
            List<Salon> lista = DaoSalones.TraerSalones();
            foreach (Salon aux in lista)
            {
                if (aux.Nombre == nombre)
                {
                    if (aux.Capacidad == capacidad)
                        return true;
                }
            }
            return false;
        }

        public List<Salon> TraerSalones()
        {
            List<Salon> lista = DaoSalones.TraerSalones();
            return lista;
        }

        public bool InsertarSalon(string nombre, int capacidad)
        {
            if (VerificarExistenciaI(nombre) == false)
            {
                DaoSalones.InsertarSalon(nombre, capacidad);
                return true;
            }
            return false;
        }

        public bool ModificarSalon(string nombre, int capacidad, int id)
        {
            if (VerificarExistenciaM(nombre, capacidad) == false)
            {
                DaoSalones.ModificarSalon(nombre, capacidad, id);
                return true;
            }
            return false;
        }

        public void EliminarSalon(int id)
        {
            DaoSalones.EliminarSalon(id);                          
        }


    }
}
