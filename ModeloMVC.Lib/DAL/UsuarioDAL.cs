using ModeloMVC.Lib.DTL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloMVC.Lib.DAL
{
    internal class UsuarioDAL
    {
        internal string verificaUsuario(UsuarioDTL _usuario)
        {
            //consulta o banco de dados

            //verifica o usuario e senha pelo sql

            //returna o valor

            return "Nome: " + _usuario.nomeUsuario;
        }
    }
}
