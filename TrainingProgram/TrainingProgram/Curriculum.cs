using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProgram
{
    public class Curriculum
    {
        public int Code { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ConfirmationDate { get; set; }

        public Degree Degree { get; set; }
        public Course Course { get; set; }
        public Course Course1 { get; set; }
        public Student Student { get; set; }

        private double cr;


        public Curriculum(Course c, Degree d, Student student, DateTime t1, DateTime t2, double cr)
        {
            Degree = d;
            Course = c;
            CreationDate = t1;
            ConfirmationDate = t2;
            Student = student;
            this.cr = cr;
        }
        public Curriculum(Course c, Course c1, Degree d, Student student, DateTime t1, DateTime t2, double cr)
        {
            Degree = d;
            Course = c;
            Course1 = c1;
            CreationDate = t1;
            ConfirmationDate = t2;
            Student = student;
            this.cr = cr;
        }


        public override string ToString()
        {
            return $"студент : {Student}, код плана : {Code},\n дата создания : {CreationDate}, дата утверждения : {ConfirmationDate}, курс : {Course.Title} + {Course1.Title},\n степень : {Degree.Title}, количество кредитных единиц курса  :  {cr}";
        }
        

    }
}
