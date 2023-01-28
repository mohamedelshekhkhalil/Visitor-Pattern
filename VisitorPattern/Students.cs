using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class Students : IElement
    {
        public string StudName { get; set; }

        public Students(string name)
        {
            StudName = name;
        }
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

}
