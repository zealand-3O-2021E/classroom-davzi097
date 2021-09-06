using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Student
    {
        private string _name;
        private int _birthmonth;
        private int _birthday;

        public Student(string name, int birthmonth, int birthday)
        {
            _name = name;
            _birthmonth = birthmonth;
            _birthday = birthday;
        }

        public string Name { get => _name; set => _name = value; }
        public int Birthmonth { get => _birthmonth; set => _birthmonth = value; }
        public int Birthday { get => _birthday; set => _birthday = value; }
    }
}
