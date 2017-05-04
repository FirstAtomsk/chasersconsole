using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ID
    {
        public string name;
        public int weight;
        public string city;
        public string login;
        public string pass;

        public ID (string _name, int _weight, string _city, string _login, string _pass )
        {
            name = _name;
            weight = _weight;
            city = _city;
            login = _login;
            pass = _pass;
        }
    }
}
