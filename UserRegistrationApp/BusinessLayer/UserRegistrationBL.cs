//using ModelLayer.DTO;

using ModelLayer.DTO;
using RepositoryLayer;

namespace BusinessLayer
{
    public class UserRegistrationBL
    {
        UserRegistrationRL _userRegistrationRL;
        public UserRegistrationBL(UserRegistrationRL userRegistrationRL) 
        {
            _userRegistrationRL = userRegistrationRL;
        }

        public string GetUserBL() 
        {
            
            
            return _userRegistrationRL.GetUserRL();
        }

        public bool RegisterUserBL(RegistrationDTO registration) 
        {
            bool registered = _userRegistrationRL.RegisterUserRL(registration.ToString());

            return registered;
        }
    }
}
