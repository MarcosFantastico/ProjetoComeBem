using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

//Importação das camadas de negócio
using ProjetoComeBem.Code.DTO;
using ProjetoComeBem.Code.DAL;

namespace ProjetoComeBem.Code.BLL
{
    
    class ComidaBLL
    {
        AcessoBancoDados obj_conexao = new AcessoBancoDados();
        //O método inserir recebe os dados via DTO
        public void inserir(ComidaDTO comidaDTO)
        {
            obj_conexao.Conectar();
            obj_conexao.ExecutarComando($"INSERT INTO comidas VALUES(NULL, '{comidaDTO.Nome}', '{comidaDTO.Ingredientes}', '{comidaDTO.Modo_preparo}')");
        }

        public void alterar(ComidaDTO comidaDTO)
        {
            obj_conexao.Conectar();
            obj_conexao.ExecutarComando($"UPDATE comidas SET nome = '{comidaDTO.Nome}',ingredientes = '{comidaDTO.Ingredientes}',modo_preparo = '{comidaDTO.Modo_preparo}' WHERE id = {comidaDTO.Id}");
        }

        public void excluir(ComidaDTO comidaDTO)
        {
            obj_conexao.Conectar();
            obj_conexao.ExecutarComando($"DELETE FROM comidas WHERE id = {comidaDTO.Id}");
        }

        public DataTable listar()
        {
            obj_conexao.Conectar();
            string sql = "SELECT * FROM comidas";
            return obj_conexao.ExecutarConsulta(sql);
        }
    }
}
