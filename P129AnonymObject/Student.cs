using System;

namespace P129AnonymObject
{
    class Student 
    {
        //Class Members - Field, Method, Property
        //Field
        public string Name;
        public string SurName;
        public byte Age;

        //Constructor - Methoddur, Class Addinnan Eyni Adda Olur, Return type olmur
        //Method Signature ve Method Overloading-i destekliyir
        public Student()
        {
            Console.WriteLine("Constructor Ise Dusdu");
        }

        public Student(string name) : this()
        {
            Name = name;
        }

        public Student(string name, string surname) : this(name)
        {
            SurName = surname;
        }

        public Student(string name, string surname, byte age) : this(name, surname)
        {
            Age = age;
        }

        public Universitet Universitet;

        public Address Address;
        //Method Signature ve Method Overloading-i destekliyir
        public string GetFullName()
        {
            return $"{Name} {SurName}";
        }
        public string GetFullName(string name)
        {
            return $"{Name} {SurName}";
        }

        public string FullInfo()
        {
            return $"{GetFullName()} {Age}";
        }
    }
}
