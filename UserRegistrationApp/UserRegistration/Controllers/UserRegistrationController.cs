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
        [Route("Login")]

        public IActionResult LoginUser([FromBody] UserLoginDTO userLoginDTO)
        {
            _logger.LogInformation("Starting the login process for the user with email {Email}", userLoginDTO.Email);
            try
            {
                LoginResponceDTO<string> loginResponce= new LoginResponceDTO<string>();
                (bool Condition, string state, string token) = _userRegistrationBL.LoginUserBL(userLoginDTO);

                if (Condition)
                {
                    loginResponce.Success = Condition;
                    loginResponce.Message = state;
                    loginResponce.Data = userLoginDTO.Email;
                    loginResponce.Token = token;
                    _logger.LogInformation("User with Email {Email} logged in successfully", userLoginDTO.Email);
                    return Ok(loginResponce);
                }
                loginResponce.Success = Condition;
                //loginResponce.Message = state;
                loginResponce.Data = userLoginDTO.Email;
                loginResponce.Token = token;
                _logger.LogWarning("Login unsuccessful for User with Email {Email} : Entered wrong credentials for login", userLoginDTO.Email);
                if(state == "Incorrect email or password") 
                {
                    loginResponce.Message = state;
                    return NotFound(loginResponce);
                }
                loginResponce.Message = state;
                return BadRequest(loginResponce);
            }
            catch (Exception ex)
            
            {
                response.Success = false;
                response.Message = "Error occured while logging";
                response.data = ex.Message;
                _logger.LogError("Error occured in Login process for user with email { Email} Error : {Error}", userLoginDTO.Email, ex.Message);
                return BadRequest(response);
            }
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

