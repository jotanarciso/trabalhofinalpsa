using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadastroAulas.Models;

namespace CadastroAulas.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Aula> Aulas { get; set; }
        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes) { }
        public DbSet<CadastroAulas.Models.AulaAluno> AulaAluno { get; set; }
    }
}
