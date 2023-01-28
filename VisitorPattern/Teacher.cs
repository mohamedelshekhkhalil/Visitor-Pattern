using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class Teacher : IVisitor
    {
        public string Name { get; set; }

        public Teacher(string name)
        { 
            Name = name;
        }

        public void Visit(IElement element)
        {
            Students stud = (Students)element;
            Console.WriteLine("Teacher : " + this.Name + " has teach the student : " + stud.StudName);
        }
    }
}
