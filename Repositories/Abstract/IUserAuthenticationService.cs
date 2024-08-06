using static SKNHPMNEW.Models.DTO.ChangePasswordModel;
using SKNHPMNEW.Models.DTO;

namespace SKNHPMNEW.Repositories.Abstract
{
    public interface IUserAuthenticationService
    {
        Task<Status> LoginAsync(LoginModel model);
        Task LogoutAsync();
        Task<Status> RegisterAsync(RegistrationModel model);
        Task<Status> ChangePasswordAsync(ChangePasswordModel model, string username);
    }
}
