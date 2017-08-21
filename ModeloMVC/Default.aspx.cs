using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ModeloMVC
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ModeloMVC.Lib.DTL.UsuarioDTL _usuarioDTL = new Lib.DTL.UsuarioDTL();
            _usuarioDTL.nomeUsuario = System.Configuration.ConfigurationManager.AppSettings["Nome"].ToString();
            _usuarioDTL.senhaUsuario = System.Configuration.ConfigurationManager.AppSettings["Senha"].ToString();
            _usuarioDTL.dataNascimento = DateTime.Now;


            ModeloMVC.Lib.BLL.UsuarioBLL _usuarioBLL = new Lib.BLL.UsuarioBLL();
            lblNome.Text = _usuarioBLL.verificaUsuario(_usuarioDTL);
            
        }

        protected void cmdEnviar_Click(object sender, EventArgs e)
        {
            if (pnlLabel.Visible)
                pnlLabel.Visible = false;
            else
                pnlLabel.Visible = true;     
        }
    }
}