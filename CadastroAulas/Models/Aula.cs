using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroAulas.Models
{
    public class Aula
    {
        [Key]
        public int Codcred { get; set; }
        public DateTime Data { get; set; }
        public string Turma { get; set; }
    }
}
