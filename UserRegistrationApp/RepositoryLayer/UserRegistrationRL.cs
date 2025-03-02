using RepositoryLayer.Interface;
using ModelLayer.DTO;
using RepositoryLayer.Context;
using RepositoryLayer.Entity;
using Microsoft.Extensions.Logging;

namespace RepositoryLayer
{
    public class UserRegistrationRL : IUserRegistrationRL
    {
        //string userData = "User";

        private readonly RegistrationAppContext _context;
        private readonly ILogger<UserRegistrationRL> _logger;

        static List<String> userData = new  List<string>();//Make it statis so once the dats is sent through post it is not re insitialised and we can get the data
        public UserRegistrationRL(RegistrationAppContext context, ILogger<UserRegistrationRL> logger) 
        {
            _context = context;
            _logger = logger;
        }

        public string GetHello(string name) 
        {
            return name + "Hello form repository layer";
        
        }

        public string GetUserRL() 
        {
            //return (userData.Length > 0) ? userData : "null";
            return (userData.Count != 0) ? userData.LastOrDefault() : "null";
        }

        public  bool RegisterUserRL(RegistrationDTO Data)
        {
            try 
            {
                _logger.LogInformation("Starting the process of registering user data in database with email {Email}", Data.Email);
                var user = _context.Users.FirstOrDefault(u => u.Email.Equals(Data.Email));
                if (user != null)
                {
                    _logger.LogWarning("User with eamil {Email} already exists", Data.Email);
                    return false;
                }
                UserEntity newUser = new UserEntity()
                {
                    Email = Data.Email,
                    FirstName = Data.FirstName,
                    LastName = Data.LastName,
                    Password = Data.Password,
                    Phone = Data.Phone,
                    //UserId = Data.UserId, -> this is not present in the UserEntity class
                    UserName = Data.UserName,

                };
                _context.Users.Add(newUser);
                _context.SaveChanges();
                _logger.LogInformation("User data with email {Email} successfully added to the database", Data.Email);
                return true;


                //userData.Add(Data);
                ////userData = Data;

                //return true;
            }
            catch (Exception ex) 
            {
                _logger.LogError("Error while adding data of user with email {Email}to the database Error : {Error}",Data.Email,  ex.Message);
                return false;
            }


        }
    }
}
