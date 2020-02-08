using System;
using System.IO;

namespace DelegatesPractice
{
    public delegate double Transformer(double a, double b);
    class Program
    {
        static void Main(string[] args)
        {
            Transformer calculator = Math.Pow;

            double[] array = { 2.1, 4.2, 8.3, 10.4 };

            TraineeNo1 no1 = new TraineeNo1();
            no1.CalculateSomething(ref array, calculator);
            foreach (double a in array) Console.WriteLine(a);

            TraineeNo1 no2 = new TraineeNo1();
            no2.CalculatePower(ref array);

            foreach (double a in array) Console.WriteLine(a);
        }


    }
}
