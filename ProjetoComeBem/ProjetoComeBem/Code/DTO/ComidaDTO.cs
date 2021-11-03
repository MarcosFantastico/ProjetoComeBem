using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoComeBem.Code.DTO
{
    class ComidaDTO
    {
        //Propriedades Privadas
        private int _id;
        private string nome;
        private string _ingredientes, _modo_preparo;


        //Métodos de encapsulamento (selecione as propriedades com o mouse e aperte (ctrl + r + e)
        public int Id { get => _id; set => _id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Ingredientes { get => _ingredientes; set => _ingredientes = value; }
        public string Modo_preparo { get => _modo_preparo; set => _modo_preparo = value; }
    }
}
