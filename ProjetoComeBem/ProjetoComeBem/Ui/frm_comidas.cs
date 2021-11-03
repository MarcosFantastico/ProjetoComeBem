using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Importação da camada de negócio
using ProjetoComeBem.Code.BLL;
using ProjetoComeBem.Code.DTO;

namespace ProjetoComeBem.Ui
{
    public partial class frm_comidas : Form
    {
        //Criação de objetos que acessam a camada de negócio
        ComidaBLL comidaBLL = new ComidaBLL();
        ComidaDTO comidaDTO = new ComidaDTO();


        public frm_comidas()
        {
            InitializeComponent();
            txt_id.Enabled = false;
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            //Preenchimento do objeto
            //comidaDTO.Id = Convert.ToInt32(txt_id.Text);
            comidaDTO.Ingredientes = txt_ingredientes.Text;
            comidaDTO.Modo_preparo = txt_modo_preparo.Text;
            comidaDTO.Nome = txt_nome.Text;
            //Envio do dto preenchido para o método inserir
            comidaBLL.inserir(comidaDTO);
            MessageBox.Show("Cadastro realizado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
