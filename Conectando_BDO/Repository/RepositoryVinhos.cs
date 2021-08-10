﻿using Conectando_BDO.Context;
using Conectando_BDO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Conectando_BDO.Repository
{
    public class RepositoryVinhos
    {
        public void Create(Vinhos model)
        {
            using (var context = new RestContext())
            {
                context.Vinhos.Add(model);
                context.SaveChanges();
            }
        }
    }
}