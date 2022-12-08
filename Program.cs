using System;

namespace lyambda
{
    class Program
    {
        static void Main()
        {
            //Задание 1
            double x1 = Convert.ToDouble(Console.ReadLine());
            if (x1 >= 1)
                Console.WriteLine(f12(x1));
            else
                Console.WriteLine(f11(x1));
            //Задание 2
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(f22(x2));
            //Задание 3
            double x3 = Convert.ToDouble(Console.ReadLine());
            if (x3 < -7)
                Console.WriteLine(f31(x3));
            else if (x3 >= 0)
                Console.WriteLine(f32(x3));
            else
                Console.WriteLine(f33(x3));
            Main();
        }
        //Задание 1
        delegate double function1(double x);

        static function1 f11 = (x) => Math.Tan(2 * x);
        static function1 f12 = (x) => Math.Pow(2 * x + 10, 3);
        //Задание 2
        delegate long function2(int x);
        static function2 f21 = (x) =>
        {
            int y = 2;
            long ans = 1;
            while (x >= y)
            {
                ans = ans * y;
                y += 2;
            }
            return ans;
        };
        static function2 f22 = (x2) => Convert.ToInt64(Math.Pow(x2, 2)) * f21(x2);
        //Задание 3
        //delegate double function3(double x);
        static function1 f31 = (x) => -3 * Math.Sin(2 * x);
        static function1 f32 = (x) =>  1/x;
        static function1 f33 = (x) => Math.Sqrt(Math.Pow(x,3)-5);






    }
}
