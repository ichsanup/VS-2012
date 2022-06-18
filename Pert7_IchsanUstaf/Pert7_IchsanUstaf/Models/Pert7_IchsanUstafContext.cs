using System.Data.Entity;

namespace Pert7_IchsanUstaf.Models
{
    public class Pert7_IchsanUstafContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, add the following
        // code to the Application_Start method in your Global.asax file.
        // Note: this will destroy and re-create your database with every model change.
        // 
        // System.Data.Entity.Database.SetInitializer(new System.Data.Entity.DropCreateDatabaseIfModelChanges<Pert7_IchsanUstaf.Models.Pert7_IchsanUstafContext>());

        public Pert7_IchsanUstafContext() : base("name=Pert7_IchsanUstafContext")
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
