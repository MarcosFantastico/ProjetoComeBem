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
            dgv_comidas.DataSource = comidaBLL.listar();
        }
        private void btn_alterar_Click(object sender, EventArgs e)
        {
            comidaDTO.Id = Convert.ToInt32(txt_id.Text);
            comidaDTO.Ingredientes = txt_ingredientes.Text;
            comidaDTO.Modo_preparo = txt_modo_preparo.Text;
            comidaDTO.Nome = txt_nome.Text;

            comidaBLL.alterar(comidaDTO);
            MessageBox.Show("Registro alterado com sucesso!", "Alteraçao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgv_comidas.DataSource = comidaBLL.listar();

        }
        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Tem certeza que quer excluir o registro?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Information).ToString() == "Yes")
            {
                comidaDTO.Id = Convert.ToInt32(txt_id.Text);
                comidaBLL.excluir(comidaDTO);
                MessageBox.Show("Registro excluido com sucesso!", "Exclusão",  MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv_comidas.DataSource = comidaBLL.listar();
            }
        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            dgv_comidas.DataSource = comidaBLL.listar();
        }

        private void frm_comidas_Load(object sender, EventArgs e)
        {
            dgv_comidas.DataSource = comidaBLL.listar();
        }

        private void comidas_cell_click(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dgv_comidas.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_nome.Text = dgv_comidas.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_ingredientes.Text = dgv_comidas.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_modo_preparo.Text = dgv_comidas.Rows[e.RowIndex].Cells[3].Value.ToString();

        }

        
    }
}
