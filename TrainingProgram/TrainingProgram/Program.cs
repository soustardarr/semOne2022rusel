using System.Data;

namespace TrainingProgram
{
    class Program
    {       
        public static void Main()
        {
            GeneralTraining training1 = new GeneralTraining();
            training1.Init();

            bool exit = true;

            while (exit)
            {
               
        

                Console.WriteLine("***********************************");
                Console.WriteLine("Выберите пункт меню:");
                Console.WriteLine("1. Просмотреть курсы.");
                Console.WriteLine("2. Квалификационная степень");
                Console.WriteLine("3. Список студентов");
                Console.WriteLine("4. Добавить учебную программу");
                Console.WriteLine("5. Выйти");


                int k = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (k)
                {
                    case 1:
                        {
                            training1.PrintCourses();
                            break;
                        }
                    case 2:
                        {
                            training1.PrintDegrees();
                            break;
                        }
                    case 3:
                        {
                            training1.PrintStudents();
                            break;
                        }
                    case 4:
                        {
                            


                            Console.WriteLine("введите id курса");
                            int courseId = int.Parse(Console.ReadLine());
                            if (!training1.ExistCourse(courseId))
                                break;
                            Console.WriteLine("введите id квалификаци");
                            int degrId = int.Parse(Console.ReadLine());
                            if (!training1.ExistDegree(degrId))
                                break;
                            Console.WriteLine("введите номер студента");
                            int number = int.Parse(Console.ReadLine());
                            if (!training1.ExistStudent(number))
                                break;

                            training1.AddNewCurriculum(courseId, degrId, number);

                            break;
                        }
                    case 5:
                        {
                            exit = false;
                            break;
                        }
                    default:
                        break;

                }


            }


        }
    }
}