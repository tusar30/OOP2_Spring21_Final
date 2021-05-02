using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCourseAssociation
{
    class Program
    {
        static void Main(string[] args)
        {
            Course a = new Course("OOP1", "C1121", "CSE");
            Course b = new Course("Webtech", "C1124", "CSE");
            Course c = new Course("OOAD", "C1215", "CSE");
            Course d = new Course("ADMS", "C2251", "CSE");
            Course e = new Course("Data Structure", "C1120", "CSE");


            Student q = new Student("Abdur", "18-34644-2", "14-04-1998", 3.21f, 118);
            Student w = new Student("Rafa", "19-54455-1", "12-07-2000", 3.27f, 67);
            Student x = new Student("Afsar", "17-78967-2", "17-09-1996", 3.58f, 137);
            Student y = new Student("Rifat", "20-78965-2", "16-02-1999", 2.58f, 86);
            Student z = new Student("Joha", "18-67855-3", "27-05-1997", 2.90f, 77);

            y.AddCourse(a, b, c, d, e);

            y.DropCourse(d);


            a.EnrolledStudent(w, x, y, z);
            b.EnrolledStudent(w, x, y);
            c.EnrolledStudent(y, z);
            d.EnrolledStudent(w, x, y);
            e.EnrolledStudent(z);

            y.Show();

            b.StudentInfo();
            c.StudentInfo();

        }
    }
}