using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using Entidades;
namespace Controladora
{
    public class ControladoraEntradas
    {
        DAOEntradas DAOEntradas = new DAOEntradas();
        Entrada entrada;

        public List<Entrada> TraerEntradasxFiesta(int id)
        {
            List<Entrada> lista = DAOEntradas.TraerEntradasxFiesta(id);
            return lista;
        }

        public List<Entrada> TraerEntradasxFiestaxDNI(int id, int dni)
        {
            List<Entrada> lista = DAOEntradas.TraerEntradasFiestaxDNI(id, dni);
            return lista;
        }

        public List<Entrada> TraerEntradasxFiestaxApellido(int id, string apell)
        {
            List<Entrada> lista = DAOEntradas.TraerEntradasFiestaxApellido(id, apell);
            return lista;
        }

        public List<Entrada> TraerEntradasxFiestaxNum(int id, int num)
        {
            List<Entrada> lista = DAOEntradas.TraerEntradasFiestaxNum(id, num);
            return lista;
        }

        public Entrada TraerEntradaFiestaxID(int id)
        {
            List<Entrada> lista = DAOEntradas.TraerEntradaFiestaxID(id);
            foreach (Entrada aux in lista)
            {
                if (aux.Id == id)
                    entrada = aux;
            }
            return entrada;
        }

        public void MarcarIngresada(int id)
        {
            DAOEntradas.MarcarEntrada(id);
        }

 
        public void InsertarEntrada(Entrada oEntrada)
        {

            DAOEntradas.IngresarEntrada(oEntrada);
        }

        public List<Entrada> TraerEntradasTodas()
        {
            List<Entrada> lista = DAOEntradas.TraerEntradasTodas();
            return lista;
        }

        public List<Entrada> TraerEntradasxDNI(int dni)
        {
            List<Entrada> lista = DAOEntradas.TraerEntradasxDNI(dni);
            return lista;
        }

        public bool VerificarNro(int nro)
        {
            List<Entrada> lista = DAOEntradas.TraerEntradasTodas();
            foreach (Entrada aux in lista)
            {
                if (nro == aux.NRO)
                {
                    return true;
                }
            }
            return false;
        }


        public void AnularEntrada(int id)
        {
            DAOEntradas.AnularEntrada(id);
        }
        
        public Entrada TraerEntradaxID(int ID)
        {
            Entrada oEntrada = new Entrada();
            List<Entrada> Lista = DAOEntradas.TraerEntradasTodas();
            foreach (Entrada aux in Lista)
            {
                if (aux.Id == ID)
                {
                    oEntrada = aux;
                }
            }

            return oEntrada;
        }

        public List<Entrada> TraerEntradasxNRO(int nro)
        {
            List<Entrada> lista = DAOEntradas.TraerEntradasxNRO(nro);
            return lista;
        }
        public List<Entrada> TraerEntradasxApellido(string ape)
        {
            List<Entrada> lista = DAOEntradas.TraerEntradasxApellido(ape);
            return lista;
        }

        public int TraerProximoNum()
        {
            int id = DAOEntradas.TraerUltimoNro();
            id++;
            return id;
        }

        public void ModificarEntrada(Entrada oEntrada)
        {
            DAOEntradas.ModificarEntrada(oEntrada);
        }
    }
}
