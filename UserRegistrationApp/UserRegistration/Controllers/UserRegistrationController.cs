using Microsoft.AspNetCore.Mvc;
using BusinessLayer;
using ModelLayer.DTO;
using BusinessLayer.Interface;
//using ModelLayer.DTO;

namespace UserRegistration.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserRegistrationController : ControllerBase
    {
        Response<String> response;
        private readonly IUserRergistrationBL _userRegistrationBL;
        private readonly ILogger<UserRegistrationController> _logger;
        public UserRegistrationController(IUserRergistrationBL userRegistrationBL, ILogger<UserRegistrationController> logger)
        {
            _userRegistrationBL = userRegistrationBL;
            _logger = logger;
        }

        [HttpGet]
        public string GetUser() 
        {
            return _userRegistrationBL.GetUserBL();
        }

        [HttpPost]
        public IActionResult RegisterUser([FromBody] RegistrationDTO registration) //Frombody helps in binding the data
        {
            try 
            {
                response = new Response<String>();
                _logger.LogInformation("Starting user registration for {Email}", registration.Email);
                bool registered = _userRegistrationBL.RegisterUserBL(registration);
                if (registered)
                {
                    response.Success = true;
                    response.Message = "User added successfully";
                    response.data = registration.UserName.ToString();
                    
                    _logger.LogInformation("User {Email} registered successfully with usrname {UserName}", registration.Email, registration.UserName);
                    return Ok(response);
                }
                response.Success = false;
                response.Message = "User Already exist";
                response.data = "User is already  registered";
                _logger.LogWarning("User {Email}  with username {UserName} Already exists", registration.Email, registration.UserName);
                return NotFound(response);
            }
            catch (Exception ex) 
            {
                response.Success = false;
                response.Message = ex.Message;
                response.data = "OOps Try again";
                _logger.LogError("Error occured while registering user Error : {Error}", ex.Message);
                return BadRequest(response);
            }
            
        }
    }
}

