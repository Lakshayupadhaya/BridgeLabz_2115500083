namespace RepositoryLayer
{
    public class UserRegistrationRL
    {
        //Credentials saved in the Database/Repository
        public string userName = "Root";
        public string password = "Root";

        //Method to get the credentials from repository/Database
        public (string userName, string password) GetCredentials() 
        {
            return (userName, password);
        }

        //Method to get the credentials and return them here we are returning it to business layer
        public (string username, string password) registrationRL() 
        {
            return GetCredentials();
        }
    }
}
