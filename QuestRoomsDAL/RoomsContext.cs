namespace QuestRoomsDAL
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class RoomsContext : DbContext
    {
        // Your context has been configured to use a 'RoomsContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'QuestRoomsDAL.RoomsContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'RoomsContext' 
        // connection string in the application configuration file.
        public RoomsContext()
            : base("name=RoomsContext")
        {
        }    


    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}