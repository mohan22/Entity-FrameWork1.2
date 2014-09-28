using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramwork1._2
{
    class DbInitializer
    {
       public DbInitializer()
        {
            var db = new StudentContext();
            Student student = new Student() { Name = "mohan" };
            Subject mathSubj = new Subject() { Name = "maths" };
            Subject scienceSubj = new Subject() { Name = "science" };
            student.Subjects.Add(mathSubj);
            student.Subjects.Add(scienceSubj);

            db.Students.Add(student);
            db.SaveChanges();

        }
    }
}
