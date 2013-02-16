using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AngularList.Models
{
    public class List
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Name { get; set; }

        public virtual ICollection<Task> Tasks { get; set; }

        public List()
        {
            Tasks = new HashSet<Task>();
        }
    }
}