using Conectando_BDO.Context;
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
        public List<Vinhos> Read()
        {
            List<Vinhos> lista = new List<Vinhos>();
            
            using (var context = new RestContext())
            {
                lista = context.Vinhos.ToList();
            }
            return lista;
        }
        public Vinhos Read(int id)
        {
            Vinhos model = new Vinhos();
            
            using (var context = new RestContext())
            {
                model = context.Vinhos.Find(id);
            }
            return model;
        }
        public void Update(Vinhos model)
        {
            using (var context = new RestContext())
            {
                context.Entry<Vinhos>(model).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Delete(int id)
        {
            using (var context = new RestContext())
            {
                context.Entry<Vinhos>(this.Read(id)).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}