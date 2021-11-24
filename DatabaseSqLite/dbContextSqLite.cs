using DatabaseCore;
using DatabaseCore.Interfaces;
using DatabaseCore.Interfaces.Tables.dbPerson;
using DatabaseSqLite.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSqLite
{
    public class dbContextSqLite : dbContextCore
    {
        private iConnection _Connection = null;
        public override iConnection Connection
        {
            get
            {
                if (this._Connection == null)
                    this._Connection = new SqLiteConnection(); ;

                return this._Connection;

            }
        }

        private iDbPerson _DbPerson = null;
        public override iDbPerson dbPerson
        {
            get
            {
                if (this._DbPerson == null)
                    this._DbPerson = new SqlitePerson(this._Connection);

                return this._DbPerson;
            }

        }


    }
}
