using System.Data.Entity;

namespace AngularList.Models
{
    public class AngularContext : DbContext
    {
        public AngularContext() : base("DefaultConnection"){}

        public DbSet<List> Lists { get; set; }
        public DbSet<Task> Tasks { get; set; }
    }
}