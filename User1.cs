using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial_Class
{
    public partial class User
    {
        private string name;
        private string location;
        public User(string a, string b)
        {
            name = a;
            location = b;
        }
    }
}
