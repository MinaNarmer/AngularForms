using System.ComponentModel.DataAnnotations;

namespace AngularForms.Data.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
            
    }
}
