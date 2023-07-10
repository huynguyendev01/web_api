namespace WepAPI_Restaurant_Management.Models
{
    public class User
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Password { get; set; }

        public string? Email { get; set; }

        public string? Description { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdateAt { get; set; }

        public bool? Deleted { get; set; }

        public bool? OfDuty { get; set; }

        public virtual Role? Role { get; set; }
    }
}
