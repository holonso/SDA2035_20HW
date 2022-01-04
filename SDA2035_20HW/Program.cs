using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p20ex01
{
    class Program
    {
        delegate double RadDelegate(double r);
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус:");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            RadDelegate radDelegate = LengthCircle;
            radDelegate += AreaCircle;
            radDelegate += VolumeBall;

            radDelegate(r);

            Console.ReadKey();


        }
        static double LengthCircle(double r)
        {
            double length = 2 * Math.PI * r;
            Console.WriteLine($"Длина окружности D = {length:f2}");
            return length;
        }
        static double AreaCircle(double r)
        {
            double area = Math.PI * r * r;
            Console.WriteLine($"Площадь окружностиs S = {area:f2}");
            return area;
        }
        static double VolumeBall(double r)
        {
            double volume = 4 / 3 * Math.PI * Math.Pow(r, 3);
            Console.WriteLine($"Объем шара V = {volume:f2}");
            return volume;
        }
    }
}
