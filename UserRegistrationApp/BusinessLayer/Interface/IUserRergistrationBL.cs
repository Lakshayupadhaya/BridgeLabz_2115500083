using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer.DTO;

namespace BusinessLayer.Interface
{
    public interface IUserRergistrationBL
    {
        string GetUserBL();

        (bool Condition, string state, string token) LoginUserBL(UserLoginDTO userLoginDTO);

        bool RegisterUserBL(RegistrationDTO registration);
    }
}
