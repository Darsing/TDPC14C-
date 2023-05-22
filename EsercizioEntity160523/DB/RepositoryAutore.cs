using EsercizioEntity160523.DB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EsercizioEntity160523.DB
{
    public class RepositoryAutore
    {
        private DBContext DBContext;
        public RepositoryAutore(DBContext DBContext)
        {
            this.DBContext = DBContext;
        }

        public void InsertAutores(Autore autore)
        {
            this.DBContext.Autores.Add(autore);
            this.DBContext.SaveChanges();
        }

        public List<Autore> GetAutores()
        {
            //select * from persons
            List<Autore> result = this.DBContext.Autores.ToList();
            return result;
        }
    }
}
