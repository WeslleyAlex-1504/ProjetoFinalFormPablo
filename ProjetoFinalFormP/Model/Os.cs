using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalFormP.Model
{
    internal class Os
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public DateTime Data { get; set; }

        public int CarroId { get; set; }

        public Boolean Ativo { get; set; }

        public DateTime DiaFinalizado { get; set; }
}
}
