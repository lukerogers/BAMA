using System.Data.Entity.Migrations;

namespace AngularList.Models
{
    public class AngularConfiguration : DbMigrationsConfiguration<AngularContext>
    {
        public AngularConfiguration()
        {
            AutomaticMigrationsEnabled = true;
        }
         
    }
}