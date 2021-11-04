
namespace ProjetoComeBem.Ui
{
    partial class frm_comidas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_comidas = new System.Windows.Forms.DataGridView();
            this.btn_listar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_inserir = new System.Windows.Forms.Button();
            this.txt_modo_preparo = new System.Windows.Forms.TextBox();
            this.lbl_modo_preparo = new System.Windows.Forms.Label();
            this.txt_ingredientes = new System.Windows.Forms.TextBox();
            this.lbl_ingredientes = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_comidas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_comidas
            // 
            this.dgv_comidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_comidas.Location = new System.Drawing.Point(20, 195);
            this.dgv_comidas.Name = "dgv_comidas";
            this.dgv_comidas.RowTemplate.Height = 25;
            this.dgv_comidas.Size = new System.Drawing.Size(570, 150);
            this.dgv_comidas.TabIndex = 25;
            this.dgv_comidas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.comidas_cell_click);
            // 
            // btn_listar
            // 
            this.btn_listar.Location = new System.Drawing.Point(425, 363);
            this.btn_listar.Name = "btn_listar";
            this.btn_listar.Size = new System.Drawing.Size(105, 40);
            this.btn_listar.TabIndex = 24;
            this.btn_listar.Text = "Listar";
            this.btn_listar.UseVisualStyleBackColor = true;
            this.btn_listar.Click += new System.EventHandler(this.btn_listar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(308, 363);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(105, 40);
            this.btn_excluir.TabIndex = 23;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Location = new System.Drawing.Point(187, 363);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(105, 40);
            this.btn_alterar.TabIndex = 22;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_inserir
            // 
            this.btn_inserir.Location = new System.Drawing.Point(74, 363);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(105, 40);
            this.btn_inserir.TabIndex = 21;
            this.btn_inserir.Text = "Inserir";
            this.btn_inserir.UseVisualStyleBackColor = true;
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // txt_modo_preparo
            // 
            this.txt_modo_preparo.Location = new System.Drawing.Point(20, 141);
            this.txt_modo_preparo.Name = "txt_modo_preparo";
            this.txt_modo_preparo.Size = new System.Drawing.Size(570, 23);
            this.txt_modo_preparo.TabIndex = 20;
            // 
            // lbl_modo_preparo
            // 
            this.lbl_modo_preparo.AutoSize = true;
            this.lbl_modo_preparo.Location = new System.Drawing.Point(20, 109);
            this.lbl_modo_preparo.Name = "lbl_modo_preparo";
            this.lbl_modo_preparo.Size = new System.Drawing.Size(102, 15);
            this.lbl_modo_preparo.TabIndex = 19;
            this.lbl_modo_preparo.Text = "Modo de preparo:";
            // 
            // txt_ingredientes
            // 
            this.txt_ingredientes.Location = new System.Drawing.Point(256, 49);
            this.txt_ingredientes.Name = "txt_ingredientes";
            this.txt_ingredientes.Size = new System.Drawing.Size(334, 23);
            this.txt_ingredientes.TabIndex = 18;
            // 
            // lbl_ingredientes
            // 
            this.lbl_ingredientes.AutoSize = true;
            this.lbl_ingredientes.Location = new System.Drawing.Point(256, 17);
            this.lbl_ingredientes.Name = "lbl_ingredientes";
            this.lbl_ingredientes.Size = new System.Drawing.Size(75, 15);
            this.lbl_ingredientes.TabIndex = 17;
            this.lbl_ingredientes.Text = "Ingredientes:";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(95, 49);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(138, 23);
            this.txt_nome.TabIndex = 16;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(95, 17);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(43, 15);
            this.lbl_nome.TabIndex = 15;
            this.lbl_nome.Text = "Nome:";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(20, 49);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(49, 23);
            this.txt_id.TabIndex = 14;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(20, 17);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(20, 15);
            this.lbl_id.TabIndex = 13;
            this.lbl_id.Text = "Id:";
            // 
            // frm_comidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 425);
            this.Controls.Add(this.dgv_comidas);
            this.Controls.Add(this.btn_listar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_inserir);
            this.Controls.Add(this.txt_modo_preparo);
            this.Controls.Add(this.lbl_modo_preparo);
            this.Controls.Add(this.txt_ingredientes);
            this.Controls.Add(this.lbl_ingredientes);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_id);
            this.Name = "frm_comidas";
            this.Text = "Comidas";
            this.Load += new System.EventHandler(this.frm_comidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_comidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_comidas;
        private System.Windows.Forms.Button btn_listar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_inserir;
        private System.Windows.Forms.TextBox txt_modo_preparo;
        private System.Windows.Forms.Label lbl_modo_preparo;
        private System.Windows.Forms.TextBox txt_ingredientes;
        private System.Windows.Forms.Label lbl_ingredientes;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_id;
    }
}