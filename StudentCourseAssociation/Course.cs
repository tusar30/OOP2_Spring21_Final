using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCourseAssociation
{
    class Course
    {
        public string courseName { get; set; }
        public string courseCode { get; set; }
        public string courseDept { get; set; }
        Student[] students;
        public int totalstudent { get; set; }

        public Course()
        {

        }
        public Course(string coursename, string coursecode, string coursedept)
        {
            courseName = coursename;
            courseCode = coursecode;
            courseDept = coursedept;
            students = new Student[30];
        }
        public void EnrolledStudent(params Student[] students)
        {
            foreach (var S in students)
            {
                this.students[totalstudent++] = S;
            }
        }

        virtual public void StudentInfo()
        {

            for (int i = 0; i < totalstudent; i++)
            {
                students[i].ShowInfo();
            }
        }

        virtual public void ShowCourseInfo()
        {
            Console.WriteLine("The course name is: {0}", courseName);
            Console.WriteLine("The course code is: {0}", courseCode);
            Console.WriteLine("The course department is :{0}", courseDept);
            Console.WriteLine("Total number of students in {0} are :{1}", courseName, totalstudent);
            Console.WriteLine("_________________________________________");
        }
    }
}