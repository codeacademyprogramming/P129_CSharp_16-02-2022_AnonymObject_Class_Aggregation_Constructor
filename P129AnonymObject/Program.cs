using System;

namespace P129AnonymObject
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Anonym Object
            //Anonym Object
            //var stu1 = new
            //{
            //    name="Alyasar",
            //    surname = "Cabbarli",
            //    age = 19,
            //    militarystatus = false
            //};

            //var stu2 = new
            //{
            //    name = "Hamid",
            //    surname = "Alekberli",
            //    age = 17,
            //    militarystatus = false
            //};

            //stu1.name = "Elyeser";

            //Console.WriteLine($"Ad: {stu1.name}\nSoyAd: {stu1.surname}");

            //ChangeName(stu1, "Elyeser");
            #endregion

            //string name = Console.ReadLine();
            //string surname = Console.ReadLine();
            //string strage = Console.ReadLine();
            //byte age = byte.Parse(strage);

            //Type instance(object) = initialize
            //Student stu1 = new Student();
            //stu1.Name = name;
            //stu1.SurName = surname;
            //stu1.Age = age;
            //string sr = stu1.GetFullName();

            //Console.WriteLine($"Ad: {stu1.Name}\nSoyadi: {stu1.SurName}\nYas: {stu1.Age}");
            //Console.WriteLine(stu1.GetFullName());
            //Console.WriteLine(stu1.FullInfo());

            //Artiq Method
            //ChangeSurName(stu1, "Elizade");

            //Console.WriteLine($"Ad: {stu1.Name}\nSoyadi: {stu1.SurName}\nYas: {stu1.Age}");
            //Console.WriteLine($"Ad Soyad: {sr}\nYas: {stu1.Age}");
            //string name = Console.ReadLine();
            //Student stu2 = new Student(/*name*/"Hamid");
            //Student stu2 = new Student();
            //Student stu2 = new Student("Hamid","Mammadov");
            Student stu2 = new Student("Hamid", "Mammadov", 31);
            Student stu3 = new Student("Test");
            Student stu4 = new Student("Test","Test");
            Student stu5 = new Student("Test","Test",36);
            //stu2.Name = "Hamid";
            //stu2.SurName = "Mammadov";
            //stu2.Age = 31;
            //Console.WriteLine($"Ad Soyad: {stu2.GetFullName()}\nYas: {stu1.Age}");
            Console.WriteLine(stu2.GetFullName());
            Console.WriteLine(stu2.FullInfo());

            //Address stuAddress = new Address();
            //stuAddress.Country = "Azerbaijan";
            //stuAddress.City = "Baki";
            //stuAddress.Street = "Dilare Aliyeva";

            //stu2.Address = stuAddress;

            stu2.Address = new Address();
            stu2.Address.Country = "Azerbaijan";
            stu2.Address.City = "Baki";
            stu2.Address.Street = "Dilare Aliyeva";

            //stuAddress.Street = "Street";
            stu2.Address.Street = "Street";

            Console.WriteLine($"{stu2.FullInfo()} {stu2.Address.Country} {stu2.Address.City} " +
                $"{stu2.Address.Street}");
        }

        //Artiq Method
        //static Student ChangeSurName(Student stu, string surname)
        //{
        //    stu.SurName = surname;
        //    return stu;
        //}

        #region Anonym Object
        //static void ChangeName(object obj, string name)
        //{

        //}
        #endregion
    }
}
