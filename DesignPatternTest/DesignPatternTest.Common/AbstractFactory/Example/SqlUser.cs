using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest
{
    public class SqlUser : IUser
    {
        public void Insert(User user)
        {
            Console.WriteLine("Sql Insert User Data");
        }

        public User GetUser(int id)
        {
            Console.WriteLine("Sql Get User Data");
            return new User();
        }
    }
}
