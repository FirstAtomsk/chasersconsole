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
        public int BP_res;
        public int BP_place;

        public ID (string _name, int _weight, string _city, string _login, string _pass, int _BP_res, int _BP_place)
        {
            name = _name;
            weight = _weight;
            city = _city;
            login = _login;
            pass = _pass;
            BP_res = _BP_res;
            BP_place = _BP_place;
        }
    }
}
