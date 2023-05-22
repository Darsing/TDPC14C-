using Microsoft.AspNetCore.Identity;

namespace IdentityAuthDB.DB.Entities
{
    //con il framework IdentityUser, sto ereditando tutti i campi che vediamo sulla
    //tabella(dbo.AspNetUser) questi sono campi custom

    public class User :IdentityUser
    {
        //posso aggiungere altri campi cui tipo
        //public string AAA{get;set;}
    }
}
