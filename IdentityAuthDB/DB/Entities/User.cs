using Microsoft.AspNetCore.Identity;

namespace IdentityAuthDB.DB.Entities
{
    //"IdentityUser" è la classe del framework che definisce l utenza
    //con il framework IdentityUser, sto ereditando tutti i campi/le properties che vediamo 
    //sulla tabella(dbo.AspNetUser) ,questi sono campi custom
    //Tramite questo class User abbiamo creato il mapping per la tabella AspNetUser
    public class User :IdentityUser
    {
        //posso aggiungere altri campi(colonne) cui tipo
        //public string AAA{get;set;}
    }
}
