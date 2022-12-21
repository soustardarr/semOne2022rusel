using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProgram
{
    public class Degree
    {
        public int Code { get; set; }
        public string Title { get; set; }

        public int CreditsRequired { get; set; }

        public int SpecialCoursesRequired { get; set; }

        public override string ToString()
        {
            return $"код {Code}, название {Title}, кредитные единцы {CreditsRequired}, cпецкурсы {SpecialCoursesRequired}";
        }


    }
}
