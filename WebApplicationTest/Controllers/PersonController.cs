using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplicationTest.Models;

namespace WebApplicationTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        

        [HttpPost("Post")]
        //Task<IActionResult> mi restituisce un oggetto che si chiama Post
        //con i suoi parametri in ingresso che è un oggetto di tipo Person
        //prende l oggetto js e lo mappa su questa classe PersonModel e diventa un oggetto c#
        //lui fa automaticamente la conversione dei campi
        //Questo attributo [FromBody] specifica che il parametro si trova nel body della richiesta
        //Dentro site.js eccolo data: JSON.stringify(body),
        public async Task<IActionResult> Post([FromBody] PersonModel person)
        {

            if (person != null)
            {
                person.Nome = person.Nome + " NEW";
                person.Cognome = person.Cognome + " NEW";
            }

            return Ok(person);
        }

        //Faccio una chiamata senza parametri GetListaStringhe() è una lista di string<List<string>>
        //Task<List<string>> questo è il tipo di return

        [HttpGet("GetListaStringhe")]
        public async Task<List<string>> GetListaStringhe()
        {
            //creo una lista di string
            List<string> result = new List<string>()
            {
                "stringa 1",
                "stringa 2"
            };

            //qui posso mettere await se voglio aspettare
            //mi permette di generare un blocco ansyncrono all interno della mia funzione
            //Questa sta girando in background ,lui crea una nuova lista sovrapone il result
            //con queste nuove valore  "stringa async 1",
            //Con await davanti io sto aspettando che lui finisce di girare
            await Task.Run(() =>
            {
                //Thread.Sleep(5000);
                result = new List<string>() {
                "stringa async 1",
                "stringa async 2"
                  };
            });
            return result;
        }

        //questa function GetDDLValue(int id) ha un parametro in ingresso che si 
        //chiama id ,se andiamo dentro site.js  var url = "/api/Person/GetDDLValue?id=" + value;
        //Creo la Dictionary ,aggiungi 3 valori e poi mi restituisce un oggetto anonimo
        [HttpGet("GetDDLValue")]
        public async Task<object> GetDDLValue(int id)
        {
            Dictionary<int, string> values = new Dictionary<int, string>();
            values.Add(0, "zero");
            values.Add(1, "uno");
            values.Add(2, "due");

            //questo è un oggetto anonimo dov'è non c è bisogno di usare una class
            //ha come properties Value = values[id]
            return new
            {
                Value = values[id]
            };
        }

        [HttpGet("GetListaMusic")]

        public async Task<object> GetListaMusic()
        {

            //List<MusicModel> result = new List<MusicModel>();
            //MusicModel model1 = new MusicModel();
            //model1.Cantante = "Queen";
            //model1.Canzone = "Love of my life";
            //result.Add(model1);

            List<MusicModel> result = new List<MusicModel>();
            result.Add(new MusicModel()
            {
                Cantante= "Queen",
                Canzone= "Love of my life"
            });
            result.Add(new MusicModel()
            {
                Cantante = "Laura Pausina",
                Canzone = "Ti amo "
            });
            result.Add(new MusicModel()
            {
                Cantante = "Davide John",
                Canzone = "Because day"
            });
            return Ok(result);
            
        }

        [HttpPost("GetFormValue")]
        public async Task<IActionResult> GetFormValue([FromBody] UtenteModel model)
        {
           //oggetti anonimo
            var response = new
            {
                value = "Input ricevuto correttamente"
            };
            return Ok(response);
        }
    }

    
}
