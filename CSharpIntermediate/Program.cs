
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace CSharpIntermediate
{


    class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person(new DateTime(1982, 1, 1));
            ////Information hiding

            //Console.WriteLine(person.Age);                                                                                                                                                                                          
            //var customer = new Customer(1);
            //customer.Name = "John";
            //var order = new Order();
            //customer.Orders.Add(order);
            //customer.Orders.Add(order);

            //Console.WriteLine("Count orders " + customer.Orders.Count());
            //Console.WriteLine(customer.Id);
            //Console.WriteLine(customer.Name);


            // UseStopWatch();
            // UsePost();
            UseStack();



        }
        static void UseStack()
        {
            Stack stack = new Stack();
            stack.Clear();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.ReadList();
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());




        }
        static void UsePost()
        {
            StackOverflow stackOverflow = new StackOverflow("My first post", "This is my first post", DateTime.Now);
            stackOverflow.UpVote();
            stackOverflow.UpVote();
            Console.WriteLine("Current Up vote" + stackOverflow.Counter);

            stackOverflow.DownVote();
            Console.WriteLine("Current Down vote" + stackOverflow.Counter);

            Console.WriteLine("Title: {0}, Description: {1}, CreatedAt: {2}", stackOverflow.Title, stackOverflow.Description, stackOverflow.CreatedAt);
        }
        static void UseStopWatch()
        {
            StopWatch stopWatch = new StopWatch();
            try
            {
                stopWatch.Stop();
                stopWatch.Start();
                stopWatch.Duration();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void UsePoints()
        {
            try
            {
                var pointer = new Pointer(10, 20);
                pointer.Move(null);
                Console.WriteLine("X value of {0}, Y value of {1}", pointer.X, pointer.Y);

                pointer.Move(100, 200);
                Console.WriteLine("X value of {0}, Y value of {1}", pointer.X, pointer.Y);

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }
        static void UseParams()
        {
            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));

        }
        static void RefOutMethod()
        {
            var isSuccess = int.TryParse("abc", out int num);
            if (isSuccess)
            {
                Console.WriteLine(isSuccess);
            }
            else
            {
                Console.WriteLine("Conversipon failed");

            }

            var a = 1;
            MyClass myClass = new MyClass();
            myClass.Mymethod(ref a);
            Console.WriteLine(a);
            int result;
            myClass.MyMethod(out result);
            Console.WriteLine(result);
        }
        //public static string BreakCamelCase(string str)
        //{
        //    var result = str.ToCharArray();

        //    for (int i = 0; i < result.Length; i++)
        //    {
        //    }

        //}
            
    }
}
