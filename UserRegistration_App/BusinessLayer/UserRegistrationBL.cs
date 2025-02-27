using RepositoryLayer;
namespace BusinessLayer
{
    public class UserRegistrationBL
    {
        //Declaring reference/instance of Repository class
        UserRegistrationRL _userRegistrationRL;

        //Constructor creating the instance of Repository class given form builder.Services.AddScope<>
        public UserRegistrationBL(UserRegistrationRL userRegistrationRL) 
        {
            _userRegistrationRL = userRegistrationRL;
        }

        //Method to get the data from repository layer and Validate credentials returning if successful or not
        public  string registrationBL(string userName, string password)
        {
            (string databaseUserName, string databasePassword) = _userRegistrationRL.registrationRL();//Calling method of repository class

            return (userName == databaseUserName && password == databasePassword)?"Login Successful":"Invalid username and password";
        }
    }
}