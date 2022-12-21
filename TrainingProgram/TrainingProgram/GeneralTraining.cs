using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TrainingProgram;

namespace TrainingProgram
{
    public class GeneralTraining
    {
        public List<Student> Students { get; set; } = new List<Student>();
        public List<Degree> Degrees { get; set; } = new List<Degree>();
        public List<Course> Courses { get; set; } = new List<Course>();
        public List<Curriculum> Curriculums { get; set; } = new List<Curriculum>();


        private Random r = new Random();     
        private DateTime GetDate(int i)
        {
            if (i == 0)
            {
                DateTime start = new DateTime(2000, 01, 01);
                DateTime end = new DateTime(2015, 01, 02);
                int range = (end - start).Days;
                return start.AddDays(r.Next(range));
            }
            else
            {
                DateTime start = new DateTime(2016, 01, 01);
                DateTime end = new DateTime(2022, 02, 02);
                int range = (end - start).Days;
                return start.AddDays(r.Next(range));
            }
        }




        public void Init()
        {
            Students.Clear();

            Students.Add(new Student
            {
                ApplicationNumber = 1,
                FullName = "Андрей",
                BirthDate = new DateTime(2004, 02, 01)
            });
            Students.Add(new Student
            {
                ApplicationNumber = 2,
                FullName = "Андрей",
                BirthDate = new DateTime(2004, 04, 02)
            });
            Students.Add(new Student
            {
                ApplicationNumber = 3,
                FullName = "Андрей",
                BirthDate = new DateTime(2004, 01, 04)
            });



            Courses.Add(new Course
            {
                Code = 1,
                Title = "Основы математики",
                IsSpecial = false,
                LectureHours = 20,
                PracticeHours = 12,
                HasExam = false,
                HasCoursePaper = false,
                Prerequisities = new List<int> {1}
            });
            Courses.Add(new Course
            {
                Code = 2,
                Title = "Дисркеная математика",
                IsSpecial = false,
                LectureHours = 20,
                PracticeHours = 12,
                HasExam = false,
                HasCoursePaper = false,
                Prerequisities = new List<int> { 1 }
            });
            Courses.Add(new Course
            {
                Code = 3,
                Title = "алгем",
                IsSpecial = true,
                LectureHours = 12,
                PracticeHours = 15,
                HasExam = true,
                HasCoursePaper = false,
                Prerequisities = new List<int>{ 1 }
            });
            Courses.Add(new Course
            {
                Code = 4,
                Title = "Матанализ",
                IsSpecial = true,
                LectureHours = 12,
                PracticeHours = 15,
                HasExam = true,
                HasCoursePaper = false,
                Prerequisities = new List<int>{ 1 }
            });
            Courses.Add(new Course
            {
                Code = 4,
                Title = "Теория Вероятности",
                IsSpecial = true,
                LectureHours = 34,
                PracticeHours = 12,
                HasExam = true,
                HasCoursePaper = true,
                Prerequisities =new List<int> { 1, 2 }
            });
            Degrees.Add(new Degree
            {
                Code = 1,
                Title = "бакалавриат",
                CreditsRequired = 5,
                SpecialCoursesRequired = 3
            });
            Degrees.Add(new Degree
            {
                Code = 2,
                Title = "магистратура",
                CreditsRequired = 6,
                SpecialCoursesRequired = 7
            });
            Degrees.Add(new Degree
            {
                Code = 3,
                Title = "аспирантура",
                CreditsRequired = 12,
                SpecialCoursesRequired = 10
            });
        }


        public void PrintStudents()
        {

            Console.WriteLine("Список студентов;");
            foreach (var prod in Students)
            {
                Console.WriteLine(prod);
            }
        }
        public void PrintDegrees()
        {
            Console.WriteLine("Список квалификаций;");
            foreach (var cust in Degrees)
            {
                Console.WriteLine(cust);
            }
        }
        public void PrintCourses()
        {
            Console.WriteLine("Список курсов;");
            foreach (var ord in Courses)
            {
                Console.WriteLine(ord);
            }
        }


        public bool ExistStudent(int id)
        {
            foreach (var c in Students)
            {
                if (c.ApplicationNumber == id)
                    return true;
            }
            return false;
        }
        public bool ExistDegree(int id)
        {
            foreach (var c in Degrees)
            {
                if (c.Code == id)
                    return true;
            }
            return false;
        }

        public bool ExistCourse(int id)
        {
            foreach (var p in Courses)
            {
                if (p.Code == id)
                    return true;
            }
            return false;
        }
       



        public void AddNewCurriculum(int courseId, int degrId, int number)
        {
            Course course  = null;
            Course course1 = null;
            Degree degr = null;
            Student student = null;

            foreach (var c in Courses)
            {
                if (c.Code == courseId)
                    course = c;
            }

            foreach (var p in Degrees)
            {
                if (p.Code == degrId)
                    degr = p;
            }
            foreach (var s in Students)
            {
                if (s.ApplicationNumber == number)
                {
                    student = s;
                }
            }

            double cr = (course.LectureHours + 1.25 * course.PracticeHours) / 18.0;
            if (cr < 2.0)
            {
                
                Console.WriteLine("не хватает кредитных единиц на требуемый уровень образовния, добавьте курс");
                Console.WriteLine("введите id курса");
                int courseId1 = int.Parse(Console.ReadLine());
                foreach (var c1 in Courses)
                {
                    if (c1.Code == courseId1)
                        course1 = c1;
                }
                double cr1 = (course1.LectureHours + 1.25 * course1.PracticeHours) / 18.0;
                cr = cr + cr1;
                var ord = new Curriculum(course,course1, degr, student, GetDate(0), GetDate(1), cr);
                Console.WriteLine("Добавлено заявление:");
                Console.WriteLine(ord);

            }
            else
            {
                var ord = new Curriculum(course, degr, student, GetDate(0), GetDate(1) , cr);
                Console.WriteLine("Добавлено заявление:");
                Console.WriteLine(ord);
            }

        }
    }
}
