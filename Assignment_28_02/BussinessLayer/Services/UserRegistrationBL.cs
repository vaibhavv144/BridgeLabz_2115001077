using ModelLayer.DTO;
using RepositoryLayer.Services;
namespace BussinessLayer.Services
{
    public class UserRegistrationBL
    {
        UserRegistrationRL _registrationRL;
        public UserRegistrationBL(UserRegistrationRL userRegistrationRL)
        {

            _registrationRL = userRegistrationRL;
        }
        public string check(User user)
        {
            if (string.IsNullOrEmpty(user.name)) return "Name Should not be Empty";
            if (string.IsNullOrEmpty(user.email)) return "Email Should not be Empty";
            if (string.IsNullOrEmpty(user.password)) return "Password Should not be Empty";
            if (string.IsNullOrEmpty(user.lname)) return "Last Name Should not be Empty";
            return "";
        }
        public bool AddUser(User user)
        {
            bool flag = _registrationRL.Adding(user);
            if (flag)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
    }
}
