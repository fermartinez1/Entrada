using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using Entidades;
namespace Controladora
{
    public class ControladoraFiestas
    {
        DAOFiestas DaoFiesta = new DAOFiestas();

        public List<Fiesta> TraerFiestas()
        {
            List<Fiesta> lista = DaoFiesta.TraerFiestas();
            return lista;
        }

        public List<Fiesta> TraerFiestasxColegio(string colegio)
        {
            List<Fiesta> lista = DaoFiesta.TraerFiestasxColegio(colegio);
            return lista;
        }

        public List<Fiesta> TraerFiestasxFecha(string fecha)
        {
            List<Fiesta> lista = DaoFiesta.TraerFiestasxFecha(fecha);
            return lista;
        }


        public Fiesta TraerFiestasxID(int id)
        {
            Fiesta oFiesta = DaoFiesta.TraerFiestasxID(id);
            return oFiesta;
        }

        public void InsertarFiesta(Fiesta oFiesta)
        {

            DaoFiesta.InsertarFiesta(oFiesta);

        }

        public void ModificarFiesta(Fiesta oFiesta)
        {
            DaoFiesta.ModificarFiesta(oFiesta);
        }

        public void EliminarFiesta(int id)
        {
            DaoFiesta.EliminarFiesta(id);
        }

    }
}
