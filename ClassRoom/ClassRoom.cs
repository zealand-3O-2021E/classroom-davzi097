using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class ClassRoom
    {
        private string _classname;
        private List<Student> _class;
        private DateTime _semesterstart;

        public ClassRoom(string classname, List<Student> @class, DateTime semesterstart)
        {
            _classname = classname;
            _class = @class;
            _semesterstart = semesterstart;
        }

        public string Classname { get => _classname; set => _classname = value; }
        public List<Student> Class { get => _class; set => _class = value; }
        public DateTime Semesterstart { get => _semesterstart; set => _semesterstart = value; }
    }
}
