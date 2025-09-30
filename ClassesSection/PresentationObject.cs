using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesSection
{
  public class PresentationObject
    {
        public int Width { get; set; }
        public int Height { get; set; }
        
        public void Copy()
        {
            Console.WriteLine("Object Copied");
        }
        public void Duplicate()
        {
            Console.WriteLine("Object Duplicated");
        }
    }
}
