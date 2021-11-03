using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
    }
}
