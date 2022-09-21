using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.@in
{
    public class Person
    {
        private string _username;
        private string _password;
        private string _name;
        private string _phoneNumber;
        private int _age;

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
    }
}
