using Microsoft.AspNetCore.Mvc;
using BusinessLayer;
using ModelLayer.DTO;
//using ModelLayer.DTO;

namespace UserRegistration.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserRegistrationController : ControllerBase
    {
        Response<String> response;
        UserRegistrationBL _userRegistrationBL;
        public UserRegistrationController(UserRegistrationBL userRegistrationBL) 
        {
            _userRegistrationBL = userRegistrationBL;
        }
        
        [HttpGet]
        public string GetUser() 
        {
            return _userRegistrationBL.GetUserBL();
        }

        [HttpPost]
        public IActionResult RegisterUser(RegistrationDTO registration) 
        {
            try 
            {
                response = new Response<String>();
                bool registered = _userRegistrationBL.RegisterUserBL(registration);
                if (registered)
                {
                    response.Success = true;
                    response.Message = "User added successfully";
                    response.data = registration.ToString();

                    return Ok(response);
                }
                response.Success = false;
                response.Message = "User Already exist";
                response.data = "User is already  registered";
                return NotFound(response);
            }
            catch (Exception ex) 
            {
                response.Success = false;
                response.Message = ex.Message;
                response.data = "OOps Try again";
                return BadRequest(response);
            }
            
        }
    }
}

