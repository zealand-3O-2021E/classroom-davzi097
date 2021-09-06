using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class ClassRoom
    {
        private string _classname;
        private List<ClassRoom> _class;
        private DateTime _semesterstart;

        public ClassRoom(string classname, List<ClassRoom> @class, DateTime semesterstart)
        {
            _classname = classname;
            _class = @class;
            _semesterstart = semesterstart;
        }

        public string Classname { get => _classname; set => _classname = value; }
        public DateTime Semesterstart { get => _semesterstart; set => _semesterstart = value; }
        internal List<ClassRoom> Class { get => _class; set => _class = value; }
    }
}
