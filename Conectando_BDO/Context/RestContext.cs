using Conectando_BDO.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Conectando_BDO.Context
{
    // Install-Package EntityFramework
    // Criar connectionString no web.config
    // Enable-Migration
    // Adicionar uma prop tipo DbSet neste arquivo de Contexto
    // Add-Migration (Para cada novo model)
    // Update-Database - Alterar o banco

    public class RestContext : DbContext
    {
        public DbSet<Vinhos> Vinhos { get; set; }
        public RestContext() : base("RestConnection")
        {
            
        }
    }
}