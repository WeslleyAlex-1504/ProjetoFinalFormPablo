using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalFormP.Model
{
    internal class Cliente
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public int Cpf { get; set; }

        public int Telefone { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public string Pais { get; set; }

        public Boolean Ativo { get; set; }
    }
}
