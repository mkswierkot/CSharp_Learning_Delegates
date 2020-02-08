using System;

namespace DelegatesPractice
{
    public delegate void MathematicalTransoformator(ref int x);
    class Program
    {
      
        static void Square (ref int x)
        {
            x *= x;
        }
        static void MultiplyBy2(ref int x)
        {
            x *= 2;
        }
        static void Main(string[] args)
        {
            int[] array = { 2,4,8,10 };
            MathematicalTransoformator mathematicalTransoformator = Square;
            mathematicalTransoformator += MultiplyBy2;
            TraineeNo1 no1 = new TraineeNo1();
            no1.CalculateSomething(ref array, mathematicalTransoformator);
   
            foreach(int a in array)
            {
                Console.WriteLine(a);
            }    

        } 


    }
}
