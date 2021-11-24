A design pattern for switching between different database technologies (e.g. SQL, SqLite)

When you write an app you may want it to work on more than one database technology. This is a possible design patter to allow switching between different database. The idea is to not have to change the core code that calls on the database. This is by using interfaces and inheritance. 

# Step one

Create all the models that will be responsable for passing data to and from the database. See the Data.Models.Person class for an example

# Step two

in DatabaseCore add all the calls that will be made to the database. This is done by creating interfaces. See the iDbPerson interface for an example.

# Step three

Add all the interfaces that would interact with the database from step 2 into the DatabaseCore.dbContextCore class. Ensure they are public virtual properties.

# Step four

Create a new project that will hold all the SQL logic for communicating with the database. See the project DatabaseSqLite for example. In that project create a a class that implements the DatabaseCore.dbContextCore interface and overrides to base class properties (see DatabaseSqLite.dbContextSqLite.cs for an example)

# Step 5

In your project that holds all the SQL logic, create a class that implements the DatabaseCore.Interfaces.iConnection interface. In hear add the logic that will all a connection to be opened and closed to and from the database.

# Step 6

Create the the SQL CRUD logic that interacts with the database. For an example see the DatabaseSqLite.Tables.SqlitePerson class that implements the DatabaseCore.Interfaces.Tables.dbPerson.iDbPerson interface.

# Step 7

Use  the Code.

using the example above we can open an connection to the database, pull out some data & then close the connection to the database.

``` c#
Person personDataFromDatabase;

// use the SqLite database
dbContextCore db = new dbContextSqLite();

db.Connection.Open();
personDataFromDatabase = db.dbPerson.Select(1);
db.Connection.Close();
```



