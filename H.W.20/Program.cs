using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.W._20
{
    class Program
    {
        delegate double MyDelegate(double a);
        static void Main(string[] args)
        {
            MyDelegate squar = Squar;
            MyDelegate length = Length;
            MyDelegate value = Value;

            double R = Convert.ToDouble(Console.ReadLine());
            double S = squar(R);
            double L = length(R);
            double V = value(R);

            Console.WriteLine($"Площадь = {S:f2}, Длина = {L:f2}, Объем равен {V:f2}") ;
            Console.ReadKey();
        }
        static double Squar(double R)
        {
            double S =R*R*Math.PI;
            return S;
        }
        static double Length(double R)
        {
            double L = 2*Math.PI*R;
            return L;
        }
        static double Value(double R)
        {
            double V = 4/3 * Math.PI * R*R*R;
            return V;
        }
    }
}
