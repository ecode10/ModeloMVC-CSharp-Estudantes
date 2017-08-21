using ModeloMVC.Lib.DAL;
using ModeloMVC.Lib.DTL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloMVC.Lib.BLL
{
    /// <summary>
    /// Classe de negócio de usuário
    /// Todo negócio de usuário deve estar nesta classe
    /// </summary>
    public class UsuarioBLL
    {
        public string verificaUsuario(UsuarioDTL _usuario) {

            UsuarioDAL _dal = new DAL.UsuarioDAL();
            return _dal.verificaUsuario(_usuario);

        }
    }
}
