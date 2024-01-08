using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OpeApp.Models
{
    public class Koment
    {
        [Key] public int KomID { get; set; }

        [Required(ErrorMessage = "Podaj ID Wpisu do którego ma przynależeć komentarz!")]
        [Column(TypeName = "nvarchar(50)")] public string WpisID { get; set; }
        [Column(TypeName = "nvarchar(100)")] public string? KomOpis { get; set; }
    }
}
