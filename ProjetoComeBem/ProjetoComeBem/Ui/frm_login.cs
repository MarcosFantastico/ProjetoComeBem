using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoComeBem.Code.BLL;
using ProjetoComeBem.Code.DTO;
namespace ProjetoComeBem.Ui
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            LoginDTO logindto = new LoginDTO();
            LoginBLL loginbll = new LoginBLL();

            logindto.email = txt_email.Text;
            logindto.senha = txt_senha.Text;

            if (loginbll.realizarLogin(logindto) == true)
            {
                frm_comidas frmcomidas = new frm_comidas();
                frmcomidas.Show();
            }
            else
            {
                MessageBox.Show("Acesso Negado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

            
        }

        private void frm_login_Load(object sender, EventArgs e)
        {

        }
    }
}
