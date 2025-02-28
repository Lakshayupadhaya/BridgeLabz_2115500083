namespace RepositoryLayer
{
    public class UserRegistrationRL
    {
        //string userData = "User";
        List<String> userData = new List<string>();
        public UserRegistrationRL() 
        {

        }

        public string GetUserRL() 
        {
            //return (userData.Length > 0) ? userData : "null";
            return (userData.Count != 0) ? userData.FirstOrDefault() : "null";
        }

        public bool RegisterUserRL(string Data) 
        {

            userData.Add(Data);
            //userData = Data;
            
            return true;
        }
    }
}
