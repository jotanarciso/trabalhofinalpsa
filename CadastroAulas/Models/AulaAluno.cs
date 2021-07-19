using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroAulas.Models
{
    public class AulaAluno
    {
        [Key]
        public int key { get; set; }
        public String Aluno { get; set; }
        public int Codcred { get; set; }
    }
}
