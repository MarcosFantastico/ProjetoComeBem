using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoComeBem.Code.DTO;
using ProjetoComeBem.Code.DAL;
using System.Data;
namespace ProjetoComeBem.Code.BLL
{
    class LoginBLL
    {
        AcessoBancoDados obj_conexao = new AcessoBancoDados();

        public bool realizarLogin(LoginDTO logindto)
        {
            obj_conexao.Conectar();
            string sql = $"SELECT * FROM usuario WHERE usuario.email = '{logindto.email}' AND usuario.senha = '{logindto.senha}'; ";
            DataTable result = obj_conexao.ExecutarConsulta(sql);

            if(result.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }



        }
    }
}
