using System;
using System.Collections.Generic;
using System.Text;

namespace Eredita240323.classeMadre
{
    internal class Figlia : Madre
    {
        private string SportPreferito { get; set; }
        public override void StampaPublic()
        {
            Console.WriteLine("Nome "+ this.Nome+" eta "+this.Age);
        }

        private void FigliaMethod()
        {
            Console.WriteLine("Il tuo sport preferito è : "+ this.SportPreferito);
        }
    }
}
