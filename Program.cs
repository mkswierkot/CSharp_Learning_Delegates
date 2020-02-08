using System;
using System.IO;

namespace DelegatesPractice
{
    public delegate void Reporter(int x);
    class Program
    {
      
        static void ReportOnConsole (int x)
        {
            Console.WriteLine(x + '%');
        }
        static void ReportToFile(int x)
        {
            StreamWriter log;

            if (!File.Exists("logfile.txt"))
            {
                log = new StreamWriter("logfile.txt");

                log.WriteLine(x + '%' + '\n');
            }
            else
            {
                log = File.AppendText("logfile.txt");

                log.WriteLine(x + '%' + '\n');
                log.Close();
            }
         
          
        }
        static void Main(string[] args)
        {
            Reporter reporter = ReportOnConsole;
            reporter = reporter + ReportToFile;
            int[] array = { 2,4,8,10 };
            TraineeNo1 no1 = new TraineeNo1();
         
            no1.CalculateSomething(ref array, reporter);
   
  

        } 


    }
}
