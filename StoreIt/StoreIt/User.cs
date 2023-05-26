using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreIt
{
    using System;
    using System.Collections.Generic;

    public class User
    {
        private Dictionary<string, string> userCredentials; 

        public User()
        {
            userCredentials = new Dictionary<string, string>();
        }

        public void AddUser(string username, string password)
        {
            if (!userCredentials.ContainsKey(username))
            {
                userCredentials.Add(username, password);
                Console.WriteLine("User created successfully.");
            }
            else
            {
                Console.WriteLine("Username already exists. Please choose a different username.");
            }
        }

        public bool UserAuthentication(string username, string password)
        {
            if (userCredentials.ContainsKey(username))
            {
                string storedPassword = userCredentials[username];
                if (password == storedPassword)
                {
                    Console.WriteLine("Authentication successful. Access granted.");
                    return true;
                }
            }

            Console.WriteLine("Authentication failed. Invalid username or password.");
            return false;
        }
    }
}

