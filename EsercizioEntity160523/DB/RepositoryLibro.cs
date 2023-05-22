using EsercizioEntity160523.DB.Entities;
using System.Collections.Generic;
using System.Linq;

namespace EsercizioEntity160523.DB
{
    public class RepositoryLibro
    {
        private DBContext DBContext;
        public RepositoryLibro(DBContext DBContext)
        {
            this.DBContext = DBContext;
        }

        public void InsertLibri(Libro libro)
        {
            this.DBContext.Libres.Add(libro);
            this.DBContext.SaveChanges();
        }

        public List<Libro> GetAutores()
        {
            //select * from persons
            List<Libro> result = this.DBContext.Libres.ToList();
            return result;
        }
    }
}
