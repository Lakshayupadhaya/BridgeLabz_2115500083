using Microsoft.AspNetCore.Mvc;
using BusinessLayer;

namespace UserRegistration.Controllers
{
    
    
    [ApiController]
    [Route("[controller]")]
    public class UserRegistrationController : ControllerBase
    {
        //Credentials from the user
        public string userName = "Root";
        public string passWord = "Root";
        
        //Declaring reference/instance of BusinessLayer class
        UserRegistrationBL _userRegistrationBL;

        //Constructor creating the instance of BusinessLayer class given form builder.Services.AddScope<>
        public UserRegistrationController(UserRegistrationBL userRegistrationBL) 
        {
            _userRegistrationBL = userRegistrationBL;
        }
        
        //Get method for our web app
        [HttpGet]
        public string Get()
        {
            return registration();
        }

        //Method to send the credentials to the Business Layer and return If login was successful or not
        public string registration() 
        {
            
            //Calling method of Business Layer providing username and password
            return _userRegistrationBL.registrationBL(userName, passWord);
        }
    }
}
