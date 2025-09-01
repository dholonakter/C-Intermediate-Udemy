using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate
{
  public class Pointer
    {
        public int X;
        public int Y;
        public Pointer(int x, int y) //if we put 100 and 200 values the currnt values 100, 200
                    {
            this.X = x;
            this.Y = y;

            
        }
        public void Move(int x, int y) //if we move to 60 and 40 from 100 and 200, the current value would be 60 and 40
        {
            this.X = x;
            this.Y = y;
        }
        public void Move(Pointer newLocation) //we are assigning the 60 and 40 to itself
        {
            if (newLocation == null)
            {
                throw new ArgumentNullException("argument can not be null");
            }
            Move(newLocation.X, newLocation.Y);
         
        }
        public void Move(Pointer newLocation, int speed) { }

    }
    public class Calculator
    {
        public int Add( params int[] numbers)
        {
            var sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum;
            
        }
    }
    public class MyClass
    {
        public void Mymethod( ref int a)
        {
            a += 2;
            Console.WriteLine(a);
        }
        public void MyMethod(out int result)
        {
            result = 1;
            Console.WriteLine(result);
        }
    }
}
