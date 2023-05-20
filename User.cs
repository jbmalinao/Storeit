using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store
{
    public class User

{

    public string Username { get; set; }

    public string Password { get; set; }

}

public void AddUser(User user)

    {

        users.Add(user);

    }

    public bool AuthenticateUser(string username, string password)

    {

        User user = users.Find(u => u.Username == username && u.Password == password);

        return user != null;
}
