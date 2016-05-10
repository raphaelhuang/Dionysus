namespace Dionysus.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class CocktailModel : DbContext
    {
        // Your context has been configured to use a 'CocktailModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Dionysus.Models.CocktailModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'CocktailModel' 
        // connection string in the application configuration file.
        public CocktailModel()
            : base("name=CocktailModel")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Cocktail> Cocktails { get; set; }
        public virtual DbSet<Ingredient> Ingredients { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}