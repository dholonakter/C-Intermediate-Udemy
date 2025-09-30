using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpIntermediate
{
    public class Stack
    {
        private List<object> list = new List<object>();

        public void Push(object obj) 
        {
            if (obj is null)
            {
                throw new NullReferenceException();
            }
            list.Add(obj);

        }
        public void ReadList()
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        public object Pop()
        {
            if (list is null)
            {
                throw new NullReferenceException();
            }
            int lastObject = list.Count() - 1;
            var obj = list[lastObject]; 
            list.RemoveAt(lastObject);

            return obj; 

        }
        public void Clear()
        {
            list.Clear();
        }
    }
}