using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramwork1._2
{
    class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }

        public virtual List<Subject> Subjects { get; set; }

        public Student()
        {
            this.Subjects = new List<Subject>();
        }
    }
}
