using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDCharp.Models.Funcionarios
{
    public class Funcionario
    {
        public int FuncionarioId { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public int Tipo { get; set; }

    }
}
