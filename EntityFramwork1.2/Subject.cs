using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramwork1._2
{
    class Subject
    {
        public int SubjectID { get; set; }
        public string Name { get; set; }
        public virtual Student student { get; set; }
    }
}
