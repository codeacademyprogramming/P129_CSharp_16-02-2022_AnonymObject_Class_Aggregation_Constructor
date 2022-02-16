using System;

namespace P129Class
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            //try
            //{
            //    bool check = bool.Parse(str);
            //}
            //catch (FormatException ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}
            //bool check1;
            //bool check = bool.TryParse(str, out check1);

            //if (check1 == true)
            //{
            //    Console.WriteLine("Cevrildi");
            //}
            //else
            //{
            //    Console.WriteLine("Cevrilmedi");
            //}

            //int a;
            //bool check = int.TryParse(str, out a);

            //if (check == true)
            //{
            //    Console.WriteLine($"Cevrildi {a}");
            //}
            //else
            //{
            //    Console.WriteLine($"Cevrilmedi {a}: Daxil Edilen Duzgun Reqem Deyil");
            //}

            //if (!int.TryParse(str, out a))
            //{
            //    Console.WriteLine($"Cevrilmedi {a}: Daxil Edilen Duzgun Reqem Deyil");
            //}
            //else
            //{
            //    Console.WriteLine($"Cevrildi {a}");
            //}


            char.IsWhiteSpace(str[0]);
            char.IsUpper(str[0]);
            char.IsLower(str[0]);
            char.IsDigit(str[0]);
            char.IsLetter(str[0]);
            char.IsSymbol(str[0]);
            char.IsControl(str[0]);

            char.ToLower(str[0]);
            char.ToUpper(str[0]);

            //Console.WriteLine("Ad: Hamid \tSoyAd: Mammadov");

            int countLower = 0;
            int countUpper = 0;
            int countDigit = 0;
            int countSymbol = 0;
            int countWhiteSpace = 0;

            foreach (char item in str)
            {
                if (char.IsLower(item))
                {
                    countLower++;
                }
                else if(char.IsUpper(item))
                {
                    countUpper++;
                }
                else if (char.IsDigit(item))
                {
                    countDigit++;
                }
                else if (char.IsSymbol(item))
                {
                    countSymbol++;
                }else if (char.IsWhiteSpace(item))
                {
                    countWhiteSpace++;
                }
            }

            string name = "Hamid";
            string surName = "Mammadov";

            Console.WriteLine($"Lower: {countLower}\nUpper: {countUpper}\nDigit: " +
                $"{countDigit}\nSymbol: {countSymbol}\nWhiteSpace: {countWhiteSpace}");

        }
    }
}
