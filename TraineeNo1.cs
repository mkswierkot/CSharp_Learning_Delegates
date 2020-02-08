using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DelegatesPractice
{
    public class TraineeNo1
    {

         public void CalculateSomething(ref int[] array, Reporter delegat)
        {

            for(int i = 0; i < array.Length; i++)
            {
                // simulating some calculatons
                Thread.Sleep(100);
                delegat(i);
            }

        }
         

    }
}
