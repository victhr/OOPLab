using System.ComponentModel.DataAnnotations;

namespace MinimalAPIBased.Models
{
    public record UserDTO(string UserName, string Password);
    public record UserModel
    {
        [Required]
        public string? UserName { get; set; }

        [Required]
        public string? Password { get; set; }
    }
}
