using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using Entidades;

namespace Controladora
{
    public class ControladoraColegios
    {
        DAOColegios DaoColegio = new DAOColegios();

        public bool VerificarExistencia(string nombre)
        {
            List<Colegio> lista = DaoColegio.TraerColegios();
            foreach (Colegio aux in lista)
            {
                if (aux.Nombre == nombre)
                {
                    return true;
                }
            }
            return false;                    
        }

        public List<Colegio> TraerColegios()
        {
            List<Colegio> lista = DaoColegio.TraerColegios();           
            return lista;
        }

        public bool InsertarColegio(string nombre)
        {
            if(VerificarExistencia(nombre)==false)
            {              
              DaoColegio.InsertarColegio(nombre);
              return true;
            }
            return false;
        }

        public bool ModificarColegio(string nombre, int id)
        {
            if (VerificarExistencia(nombre) == false)
            {
                DaoColegio.ModificarColegio(nombre, id);
                return true;
            }
            return false;
        }

        public void EliminarColegio(int id)
        {
            DaoColegio.EliminarColegio(id);
        }
    }
}
