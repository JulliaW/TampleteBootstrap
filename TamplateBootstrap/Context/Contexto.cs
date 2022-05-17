using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TamplateBootstrap.Models;

namespace TamplateBootstrap.Context
{
    public class Contexto : DbContext
    {
        public Contexto() : base("DBFuncionarios")
        {

        }

        public DbSet<funcionarioModel> Funcionarios { get; set; }
    }
}