using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class School
    {
        private static List<IElement> elements;
        static School()
        {
            elements = new List<IElement>
            {
                new Students("Mohamed Elshekh Khalil"),
                new Students("Ahmed Al-Mosallam"),
                new Students("Mohamed Al-Balawi")
            };
        }

        public void perphormOperation(IVisitor visitor)
        {
            foreach (var stud in elements)
            {
                stud.Accept(visitor);
            }
        }
    }
}
