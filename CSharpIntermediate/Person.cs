using System;

namespace CSharpIntermediate
{
   public class Person
    {
        private DateTime _birthdate;
        private string _name;
        //
        public DateTime BirthDate { get; private set; }
        public string Name { get; set; }
       
        public Person(DateTime birthdate)
        {
            BirthDate = birthdate;
        }
        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - BirthDate;
                var years = timeSpan.Days / 365;
                return years;

            }
        }
        //
        public void SetName(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                this._name = name;
            }
        }
        public string GetName()
        {
            return _name;
        }
        public void SetBirthDate(DateTime birthdate)
        {
           
                _birthdate = birthdate;
        }
        public DateTime GetBirthDate()
        {
            return _birthdate;
        }
        public void Introduce(string str)
        {
            Console.WriteLine("Hi, I am {0}, introducing to {1}", str, _name);
        }
        public static Person Parse(string str)
        {
            return null;
        }
    }
}
