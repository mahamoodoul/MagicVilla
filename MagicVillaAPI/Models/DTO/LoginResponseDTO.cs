namespace MagicVillaAPI.Models.DTO
{
    public class LoginResponseDTO
    {
        // public LocalUser User { get; set; }
        
        public UserDTO User { get; set; }
        // public string Role { get; set; }
        public string Token { get; set; }
    }
}