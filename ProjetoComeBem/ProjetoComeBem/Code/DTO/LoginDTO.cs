using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoComeBem.Code.DTO
{
    class LoginDTO
    {
        private int _id;
        private string _email, _senha;

        public int id { get => _id; set => _id = value; }

        public string email { get => _email; set => _email = value; }

        public string senha { get => _senha; set => _senha = value; }

    }
}
