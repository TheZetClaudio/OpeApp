using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OpeApp.Models
{
    public class Wpis
    {
        [Key] public int WpisID { get; set; }

        [Required(ErrorMessage = "Podaj Nazwe")]
        [Column(TypeName = "nvarchar(50)")] public string WpisName { get; set; }
        [Column(TypeName = "nvarchar(500)")] public string? WpisOpis { get; set; }
    }
}
