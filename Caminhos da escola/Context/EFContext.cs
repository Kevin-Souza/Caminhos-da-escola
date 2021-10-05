using Caminhos_da_escola.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Caminhos_da_escola.Context
{
    public class EFContext : DbContext
    {
        public EFContext() : base("ESCOLA") { }
        public DbSet<Aluno> alunos { get; set; }
    }
}