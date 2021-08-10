using Conectando_BDO.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Conectando_BDO.Context
{
    public class RestContext : DbContext
    {
        public DbSet<Vinhos> Vinhos { get; set; }

        public RestContext() : base("RestConnection")
        {
            
        }
    }
}