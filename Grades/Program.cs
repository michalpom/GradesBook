using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            //SpeechSynthesizer synth = new SpeechSynthesizer();
            //synth.Speak("Hello! This is the grade book program. Czy to polski syntezator?");


         

            
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);
            book.AddGrade(60);
            book.AddGrade(59);
            book.AddGrade(82);
            book.AddGrade(95);

            GradeStatististics stats = book.ComputeStatistics();
            Console.WriteLine(stats.AverageGrade);
            Console.WriteLine(stats.HighestGrade);
            Console.WriteLine(stats.LowestGrade);
            

            //GradeBook book2 = book; //= new GradeBook();
            //book2.AddGrade(75);

            //book2.grades




            //ctro cw tabx2

            //test for github
        }
    }

}
