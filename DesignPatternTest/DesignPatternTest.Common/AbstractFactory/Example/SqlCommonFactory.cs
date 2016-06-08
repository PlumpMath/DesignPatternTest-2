using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest
{
    public class SqlCommonFactory : ICommonFactory
    {
        public IUser CreateUser()
        {
            return new SqlUser();
        }
    }
}
