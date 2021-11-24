using DatabaseCore.Interfaces;
using DatabaseCore.Interfaces.Tables.dbPerson;

namespace DatabaseCore
{
    public class dbContextCore
    {
        public virtual iConnection Connection { get; }
        public virtual iDbPerson dbPerson { get; }
    }
}
