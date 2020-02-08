using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesPractice
{
    public class TraineeNo1
    {

        // whatever we plug-in to our method by delegate 'deleage', calculation will be different
        // on that basis
        public void CalculateSomething(ref int[] array, MathematicalTransoformator delegat)
        {
            for(int i = 0; i < array.Length; i++)
            {
                delegat(ref array[i]);
            }

        }
         

    }
}
