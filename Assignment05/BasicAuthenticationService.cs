using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment05
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        private Dictionary<string, string> users = new Dictionary<string, string>
        {
            { "user1", "password1" },
            { "user2", "password2" }
        };

        private Dictionary<string, List<string>> userRoles = new Dictionary<string, List<string>>
        {
            { "user1", new List<string> { "Admin", "User" } },
            { "user2", new List<string> { "User" } }
        };

        public bool AuthenticateUser(string username, string password)
        {
            if (users.ContainsKey(username) && users[username] == password)
            {
                return true;
            }
            return false;
        }

        public bool AuthorizeUser(string username, string role)
        {
            if (userRoles.ContainsKey(username) && userRoles[username].Contains(role))
            {
                return true;
            }
            return false;
        }
    }
}
