using MagicVillaAPI.Models;
using MagicVillaAPI.Models.DTO;

namespace MagicVillaAPI.Repository.IRepository
{
    public interface IUserRepository
    {
        bool IsUniqueUser(string username);
        Task<LoginResponseDTO> Login(LoginRequestDTO loginRequestDTO);
        // Task<LocalUser> Register(RegisterationRequestDTO registerationRequestDTO);
        Task<UserDTO> Register(RegisterationRequestDTO registerationRequestDTO);

    }
}