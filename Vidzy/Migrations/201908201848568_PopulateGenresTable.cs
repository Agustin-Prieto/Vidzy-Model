namespace Vidzy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres VALUES (1,'Acci�n')");
            Sql("INSERT INTO Genres VALUES (3,'Comedia')");
            Sql("INSERT INTO Genres VALUES (2,'Ciencia ficci�n')");
        }
        
        public override void Down()
        {
        }
    }
}
