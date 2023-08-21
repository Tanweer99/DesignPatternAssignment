using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystemProject.DatabaseLayer
{
    /// <summary>
    /// This class is used to simulate data access layer.
    /// </summary>
    public class UserDatabase
    {
        /// <summary>
        /// A method to return subscribed hardcoded users.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<User> GetSubscribedUsers()
        {
            return new List<User>()
            {
                new User("Anshul Jubli", "anshul.jubli@gmail.com", "9823456320"),
                new User("Khabib Nurmagomedov", "khabib.Nurmagomedov@gmail.com", "3456235678"),
                new User("Conor McGregor", "conor.mcGregor", "2356789867")
            };
        }
    }

    /// <summary>
    /// Class to represent User with respective properties.
    /// </summary>
    public class User
    {
        public string Name { get; set; }    
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public User(string name, string email, string phoneNumber)
        {
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;  
        }
    }
}
