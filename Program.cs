using System;

namespace DelegatesPractice
{
    public delegate int MathematicalTransoformator(int x);
    class Program
    {
      
        static int Square (int x)
        {
            return x * x;
        }
        static void Main(string[] args)
        {
            int[] array = { 0, 1, 1, 2, 3, 5, 8, 13, 21 };
            MathematicalTransoformator mathematicalTransoformator = Square;  

            TraineeNo1 no1 = new TraineeNo1();
            no1.CalculateSomething(ref array, mathematicalTransoformator);
   
            foreach(int a in array)
            {
                Console.WriteLine(a);
            }    

        } 


    }
}
