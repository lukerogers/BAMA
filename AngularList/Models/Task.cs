using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace AngularList.Models
{
    public class Task
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Label { get; set; }

        public bool Complete { get; set; }

        [JsonIgnore]
        public List List { get; set; }
    }
}