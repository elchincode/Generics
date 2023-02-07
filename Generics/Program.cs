using System;

namespace test
{
    public class Program
    {
        static void Main(string[] args)
        {

            GetDetails<string>("apple");


            Swap<int>(5, 3);


        }



        static void GetDetails<T>(T type)
        {
            Console.WriteLine(type);
        }

        static void Swap<T>(T a, T b)
        {
            T temp = a;
            a = b;
            b = temp;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }



        /*
          static T GetDetails<T>(T type)  /////// Mellim bu cure yazilis duz sayilir
        {
            return type;
        }


        */
    }
}
