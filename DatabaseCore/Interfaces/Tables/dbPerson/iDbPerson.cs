using Data.Models;

namespace DatabaseCore.Interfaces.Tables.dbPerson
{
    public interface iDbPerson : iConnectionProperty
    {
        public Person Insert(Person p);
        public Person Update(Person p);
        public void Delete(Person p);
        public Person Select(int PersonID);
    }
}
