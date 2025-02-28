using ModelLayer.DTO;
using System;
using System.Collections.Generic;

namespace RepositoryLayer.Services
{
    public class UserRegistrationRL
    {
        private List<User> li = new List<User>();

        public bool Adding(User user)
        {
            if (user != null && !string.IsNullOrEmpty(user.name) &&
                !string.IsNullOrEmpty(user.email) &&
                !string.IsNullOrEmpty(user.lname) &&
                !string.IsNullOrEmpty(user.password))
            {
                li.Add(user);
                return true;
            }
            return false;
        }


    }
}