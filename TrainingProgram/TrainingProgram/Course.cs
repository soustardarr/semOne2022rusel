using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProgram
{
    public class Course
    {
        public int Code { get; set; }
        public string Title { get; set; }

        public bool IsSpecial { get; set; }
        public int LectureHours { get; set; }
        public int PracticeHours { get; set; }

        public bool HasExam { get; set; }
        public bool HasCoursePaper { get; set; }    

        public List<int> Prerequisities { get; set; }

        public override string ToString()
        {
            
            return $"код {Code}, название {Title}, наличие спецкурса  {IsSpecial}, часов лекций  {LectureHours}, часы практики  {PracticeHours}, наличие экамена  {HasExam}, курсовая работа {HasCoursePaper}, обязательные курсы №  {string.Join(",", Prerequisities)}";
        }

    }
}
