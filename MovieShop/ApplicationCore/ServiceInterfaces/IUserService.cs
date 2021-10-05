using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.ServiceInterfaces
{
   public interface IUserService
    {
        Task<UserRegisterResponseModel> RegisterUser(UserRegisterRequestModel requestModel);
        //Task<UserRegisterResponseModel> EditUser(UserEditRequestModel requestModel);
        Task  EditUser(UserEditRequestModel requestModel);
        Task<UserLoginResponseModel> ValidateUser(string email, string password);

    }
}
