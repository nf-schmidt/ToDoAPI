using System.ComponentModel.DataAnnotations;
namespace ToDoAPI.Models
{
    public class Item
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        public bool IsComplete { get; set; }

        [Range(1, 3, ErrorMessage = "Priority must be between 1 and 3")]
        public int Priority { get; set; }
    }
}
