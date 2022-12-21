using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP
{
    internal class Company : Person
    {
        private string title;
        public string Title { get; set; }


        
        public Company (string title, string name, int age) : base (name, age)
        {
            Title = title;
        }
        public override string ToString()
        {
            return $"{title}";
        }
    }
}
