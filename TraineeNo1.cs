using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DelegatesPractice
{
    public interface ICalculator
    {
        void CalculatePower(ref double[] array,  double b);
    }
    public class TraineeNo1 : ICalculator
    {
        public void CalculateSomething(ref double[] array, Transformer delegat)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = delegat(array[i], 2.0);
            }

        }
        public void CalculatePower(ref double[] array,  double b = 2.0)
        {
            foreach (double a in array) Math.Pow(a, b);

        }

    }
}
