using Data.Models;
using DatabaseCore.Interfaces;
using DatabaseCore.Interfaces.Tables.dbPerson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSqLite.Tables
{
    public class SqlitePerson : iDbPerson
    {
        public iConnection Connection { get; set; }
        public SqlitePerson(iConnection connection)
        {
            this.Connection = connection;
        }

        public void Delete(Person p)
        {

        }



        public Person Select(int PersonID)
        {
            return null;
        }

        public Person Update(Person p)
        {
            return null;
        }

        public Person Insert(Person p)
        {
            return null;
        }
    }
}

