using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest
{
    public class SqliteUser : IUser
    {
        public void Insert(User user)
        {
            Console.WriteLine("Sqlite Insert User Data");
        }

        public User GetUser(int id)
        {
            Console.WriteLine("Sqlite Get User Data");
            return new User();
        }
    }
}
