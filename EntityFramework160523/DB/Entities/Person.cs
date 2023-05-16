using System;

namespace EntityFramework160523.DB.Entities
{
    //Guid è un tipo di dato che viene utilizzata per generare gli id alfanumerici ,hanno n vantaggi
    //rispetto ai numeri,si genera id univoci
    //decimal? per dire che questo valore può essere null =>(il suo valore di default non sarà piu 0)
    public class Person
    {
        public Guid ID { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public decimal? Stipendio { get; set; }
    }
}
