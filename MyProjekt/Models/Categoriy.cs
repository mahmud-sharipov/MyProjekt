using System.ComponentModel.DataAnnotations;
using System.Data;
namespace MyProjekt.Models
{
    public class Categoriy
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public int DisplyOrder { get; set; }
        public DateTime CreatedeDateTime { get; set; } = DateTime.Now;
    }
}
