using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Caminhos_da_escola.Models
{
    public class Aluno
    {
        public long Alunoid { get; set; }
        public string Nome { get; set; }
        public int Matricula { get; set; }
        public string Curso { get; set; }
        public string Semestre { get; set; }
    }
}