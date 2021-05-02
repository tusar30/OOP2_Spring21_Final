using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCourseAssociation
{
    class Student
    {
        public string Name { get; set; }
        public string Id { get; }
        public string Dob { get; set; }
        public float Cgpa { get; set; }
        public int Credit { get; set; }

        Course[] courses;
        public int countCourse { get; set; }
        public Student()
        {

        }

        public Student(string name, string id, string dob, float cgpa, int credit)
        {
            Name = name;
            Id = id;
            Dob = dob;
            Cgpa = cgpa;
            Credit = credit;
            courses = new Course[5];
        }
        public void AddCourse(params Course[] courses)
        {
            foreach (var c in courses)
            {
                this.courses[countCourse++] = c;
            }
        }
        public void DropCourse(Course A)
        {
            for (int i = 0; i < countCourse; i++)
            {
                if (courses[i] == A)
                {
                    int pos = i;
                    for (i = pos; i < countCourse - 1; i++)
                    {
                        courses[i] = courses[i + 1];
                    }
                }
            }
            countCourse--;
        }

        public void Show()
        {
            for (int i = 0; i < countCourse; i++)
            {
                courses[i].ShowCourseInfo();
            }
        }


        virtual public void ShowInfo()
        {
            Console.WriteLine("Student Name:{0}", Name);
            Console.WriteLine("Student ID:{0}", Id);
            Console.WriteLine("DOB:{0}", Dob);
            Console.WriteLine("Cgpa:{0} ", Cgpa);
            Console.WriteLine("Total Credit:{0}", Credit);
            Console.WriteLine("____________________");
        }

    }
}