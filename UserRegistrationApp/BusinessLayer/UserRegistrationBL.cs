//using ModelLayer.DTO;

using BusinessLayer.Interface;
using ModelLayer.DTO;
using RepositoryLayer;
using RepositoryLayer.Interface;

namespace BusinessLayer
{
    public class UserRegistrationBL : IUserRergistrationBL
    {
        private readonly IUserRegistrationRL _userRegistrationRL;
        public UserRegistrationBL(IUserRegistrationRL userRegistrationRL) 
        {
            _userRegistrationRL = userRegistrationRL;
        }

        public string GetUserBL() 
        {
            
            
            return _userRegistrationRL.GetUserRL();
        }

        public (bool Condition, string state, string token) LoginUserBL(UserLoginDTO userLoginDTO)
        {
            //(Condition, state, token) = _userRegistrationRL.UserLoginRL(userLoginDTO);
            return _userRegistrationRL.UserLoginRL(userLoginDTO);
        }

        public bool RegisterUserBL(RegistrationDTO registration) 
        {
            //bool registered = _userRegistrationRL.RegisterUserRL(registration.ToString());

            return _userRegistrationRL.RegisterUserRL(registration);
        }
    }
}
