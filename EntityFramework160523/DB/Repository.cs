﻿using EntityFramework160523.DB.Entities;
using System.Collections.Generic;
using System.Linq;

namespace EntityFramework160523.DB
{
    public class Repository
    {
        //Questa classe è il layourt finale che parla con DB
        //field del tipo DBContext
        private DBContext DBContext; 
        public Repository(DBContext DBContext)
        {
            this.DBContext = DBContext;
        }
        public List<Person> GetPersons()
        {
            //select * from persons
            List<Person> result = this.DBContext.Persons.ToList();
            return result;
        }
        public Person GetPersonByID(string id)
        {
            //select * from persons where id = "id"
            Person result = this.DBContext.Persons.Where(p => p.ID.ToString() == id).FirstOrDefault();
            return result;
        }
        public List<Person> GetPersonWithFilter(string filter)
        {
            //select * from persons where nome like "%filter%"
            //or cognome like "%filter%"
            List<Person> result = this.DBContext.Persons
                .Where(p => p.Nome.Contains(filter)
                || p.Cognome.Contains(filter)).ToList();
            return result;
        }
        public void InsertPerson(Person person)
        {
            this.DBContext.Persons.Add(person);
            this.DBContext.SaveChanges();
        }
        public void UpdatePerson(Person person)
        {
            this.DBContext.Persons.Update(person);
            this.DBContext.SaveChanges();
        }
        public void DeletePerson(string ID)
        {
            Person toDelete = this.DBContext.Persons
                    //.Where(p => p.ID != null && p.ID.Value.ToString() == ID) nel caso fosse nullable
                    .Where(p => p.ID.ToString() == ID)
                    .FirstOrDefault();
            this.DBContext.Persons.Remove(toDelete);
            this.DBContext.SaveChanges();
        }
    
}
}
