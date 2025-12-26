using System.ComponentModel.DataAnnotations;

namespace BlazorAppFluent.Shared.Entities
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(60)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        [Range(1, 120)]
        public int Age { get; set; }
    }
}