using System;
using System.Collections.Generic;
using System.Text;

namespace Eredita240323.classeMadre
{
    internal class Madre
    {
        public string Nome { get; set; }    
        protected int Age { get; set; } 
        private string Professione { get; set; }    

        public virtual  void StampaPublic() 
        {
            Console.WriteLine("Sono la classe madre public ,Nome " + this.Nome + " eta : " + this.Age);
        }

        protected void StampaProtected()
        {
            Console.WriteLine("Sono la classe madre protected ,Nome "+ this.Nome+ " eta : "+ this.Age);
        }

        private  void StampaPrivate()
        {
            Console.WriteLine("Sono private classe madre "+ this.Professione);
            Console.WriteLine("sono private classe madre "+ this.Age + " "+ this.Nome);
        }
    }
}
