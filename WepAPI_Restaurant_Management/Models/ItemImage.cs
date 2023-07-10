using System.ComponentModel.DataAnnotations;

namespace WepAPI_Restaurant_Management.Models
{
    public class ItemImage
    {
        [Key]
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Data { get; set; }

        public string? Description { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Updated { get; set; }

        public bool? Deleted { get; set; }
    }
}
