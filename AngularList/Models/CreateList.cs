using System.ComponentModel.DataAnnotations;

namespace AngularList.Models
{
    public class CreateList
    {
        [Required, StringLength(50)]
        public string Name { get; set; } 
    }
}