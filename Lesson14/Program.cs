using System;

namespace Lesson14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Method3(1,y:2,z:3);
            Method4(new int[] { 1, 2, 3, 4, 5 });
            Method4(1, 2, 3, 4, 5);
            Method5("str", 1, 2, 3, 4, 5,"str");
            int x = 100;
            Method6(ref x);

            Method7(10, out int y, out _);
            var t = y;

            var result = Method7(10);

            (int a, _) = Method8(10);
        }

        static void Method1()
        {

        }

        static void Method2(int x, float y, string str)
        {

        }

        static string Method2(int x, float y, string str, string str2)
        {
            return $"{x}{y}{str}{str2}";
        }

        static void Method3(int x, int z = 0, int y = 0)
        {

        }

        static void Method4(int x, int y, int z, int a, int b) //int[] array
        {

        }
        
        static void Method4(params int[] data) 
        {
            
        }

        static void Method5(string str, params object[] data)
        {

        }

        static void Method6(ref int x)
        {
            x = 20;
        }

        static void Method7(int x, out int y, out int z)
        {
            y = x + 20;
            z = x + 30;
        }

        static Method7Result Method7(int x)
        {
            Method7Result result = new Method7Result()
            {
                Y = x + 20,
                Z = x + 30
            };

            return result;
        }

        static (int, int) Method8(int x)
        {
            return (x+20, x+30);
        }
    }
}
