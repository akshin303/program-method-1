using System;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(3,4));
            Console.WriteLine(Kvadrat(3));
            Console.WriteLine(Reqemcem(123));
            Console.WriteLine(Orta(1,4,5,7));
            Console.WriteLine(Vara("qwe"));
        }
        static int Sum(int number1,int number2)
        // - Verilmiş iki ədədi toplayıb nəticəsini qaytaran metod
        {
            return number1 + number2;
        }
         //- Verilmiş ədədin kvadratını qaytaran metod
        static int Kvadrat(int number1)
        {
            return number1 * number1;
        }
        static int Reqemcem(int number1)
        // - Verilmiş ədədin rəqəmləri cəmini qaytaran metod
        {
            var sum = 0;
            int numson = 0;
            while(number1>0)
            {
                numson = number1 % 10;
                number1 = (number1 - numson) / 10;
                sum += numson;

            }
            return sum;
        }
        //verilmish 4 reqemin edeti ortasini tapan method
        static float Orta(float number1,float number2,float number3,float number4)
        {
            var sum = number1+number2+number3+number4;
            var count = 4;
            return sum / count;

        }
        //- Verilmiş string dəyərində a hərfinin olub olmadığını qaytaran metod
        static bool Vara(string name)
        {
            bool vara=false;
            for(int i=0;i<name.Length;i++)
            {
                if(name[i] == 'a')
                    vara=true;
            }
            if (vara == false)
                return false;
            else
                return true;
        }






    }
}
