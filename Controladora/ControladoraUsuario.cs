using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using Entidades;
using System.Data;

namespace Controladora
{
    public class ControladoraUsuario
    {
        DAOUsuario DaoUsuario = new DAOUsuario();
        Usuario oUsuario;

        public List<Usuario> TraerUsuarios()
        {
            List<Usuario> Lista = DaoUsuario.TraerUsuarios();
            return Lista;
        }

        public Usuario TraerUsuarioLogin(string usu, string contraseña)
        {
            try
            {
                
                List<Usuario> lista = DaoUsuario.TraerUsuarios();
                foreach (Usuario aux in lista)
                {
                    if (aux.Nombre == usu)
                    {
                        if (aux.Contraseña == contraseña)
                            oUsuario = aux;
                    }
                }
                return oUsuario;
            }
            catch
            {
                throw new Exception("Error al verificar usuarios");
            }
        }
    }
}
