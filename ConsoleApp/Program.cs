// See https://aka.ms/new-console-template for more information


using Data.Models;
using DatabaseCore;
using DatabaseSqLite;

namespace ConsoleApp1
{

    public partial class Program
    {
        public static int Main(string[] args)
        {
            Person personDataFromDatabase;

            // use the SqLite database
            dbContextCore db = new dbContextSqLite();

            db.Connection.Open();
            personDataFromDatabase = db.dbPerson.Select(1);
            db.Connection.Close();




            return 0;

        }

    }











}