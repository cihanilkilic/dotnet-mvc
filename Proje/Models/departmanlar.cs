using System.ComponentModel.DataAnnotations;

namespace Proje.Models
{
    public class departmanlar
    {
        [Key]
        public int Id { get; set; }
        public string departmanad { get; set; }
        public string Detay { get; set; }
        public string GorevAdami { get; set; }

    }
}
