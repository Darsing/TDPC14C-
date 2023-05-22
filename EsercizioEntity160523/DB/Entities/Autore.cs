using System;
using System.Collections.Generic;

namespace EsercizioEntity160523.DB.Entities
{
    public class Autore
    {
        public Guid IdAutore { get; set; }
        public string Nome { get; set; }

        public List<Libro> libri { get; set; }
    }
}
