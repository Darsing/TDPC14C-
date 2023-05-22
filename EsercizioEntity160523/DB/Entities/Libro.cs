using System;

namespace EsercizioEntity160523.DB.Entities
{
    public class Libro
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int NumeroPagine { get; set; } 
        public Guid IdAutore { get; set; }
        public Autore Autore { get; set; }

    }
}
