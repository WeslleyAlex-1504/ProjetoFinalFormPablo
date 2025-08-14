using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalFormP.Model
{
    internal class Servico
    {
        public int Id { get; set; }

        public string SerRealizado { get; set; }

        public string Peca { get; set; }

        public int OsId { get; set; }

        public int FuncionarioId { get; set; }

        public Boolean Ativo { get; set; }
    }
}
