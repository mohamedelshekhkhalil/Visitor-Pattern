using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class Doctor : IVisitor
    {

        public string Name { get; set; }
        public Doctor(string name)
        {
            Name = name;
        }

        public void Visit(IElement element)
        {
            Students stud = (Students)element;
            Console.WriteLine("Doctor : " + this.Name + " made check up for student with name : " + stud.StudName);
        }
    }
}
