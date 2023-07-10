using System.ComponentModel.DataAnnotations;

namespace WepAPI_Restaurant_Management.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public string? OrderNumber { get; set; }

        public string? Description { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Updated { get; set; }

        public bool? Deleted { get; set; }

        public bool? Voided { get; set; }

        public double? TotalPrice { get; set; }

        public double? PaidAmount { get; set; }

        public virtual IList<OrderItem>? OderItems { get; set; }
    }
}
