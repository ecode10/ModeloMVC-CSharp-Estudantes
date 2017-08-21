using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloMVC.Lib.DTL
{
    /// <summary>
    /// Classe de usuário com as propriedades iguais as do banco de dados
    /// Propriedades específicas do usuário
    /// </summary>
    public class UsuarioDTL
    {
        public string nomeUsuario { get; set; }

        public string senhaUsuario { get; set; }

        public int idUsuario { get; set; }

        public DateTime dataNascimento { get; set; }
    }
}
