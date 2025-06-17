using App.Common.Models;
using AuthService.Model;

namespace AuthService.Service.IService
{
    public interface IUserService
    {
        Task<AppResponse> Register(UserDto userDto);
        Task<AppResponse<LoginResDto>> Login(LoginReq req);
        Task<AppResponse<UserDto>> BookAndGetAvailablePartenerAsync();
        Task<AppResponse> ChangeAvailabilityStatusAsync(ChangeAvailabilityReqDto req);
    }
}
