using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class Student
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

        public string Name { get => _name; }
        public int Birthmonth { get => _birthmonth; }
        public int Birthday { get => _birthday; }
    }
}
