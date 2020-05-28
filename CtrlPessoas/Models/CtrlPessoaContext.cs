using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CtrlPessoas.Models
{
    public class CtrlPessoaContext: DbContext
    {
        public CtrlPessoaContext(DbContextOptions<CtrlPessoaContext> options):base(options)
        { }

        public DbSet<Pessoa> Pessoas { get; set; }
    }
}
