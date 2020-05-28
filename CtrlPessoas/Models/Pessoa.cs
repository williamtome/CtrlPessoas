using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CtrlPessoas.Models
{
    public class Pessoa
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public DateTime dataNascimento { get; set; }
        public bool Ativado { get; set; }
    }
}
