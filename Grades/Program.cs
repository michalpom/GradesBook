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

            //book.NameChanged += new NameChangedDelegate(OnNameChanged);
            //book.NameChanged += new NameChangedDelegate(OnNameChanged2);
            //book.NameChanged += OnNameChanged;
            


            //book.Name = "Scott's Grade Book";
            //book.Name = null; //zabaepieczone przed tym w property w GradeBook
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);
            book.AddGrade(60);
            book.AddGrade(59);
            book.AddGrade(82);
            book.AddGrade(95);
            book.WriteGrades(Console.Out);

            GradeStatististics stats = book.ComputeStatistics();
            Console.WriteLine(book.Name);
            WriteResult("Average",stats.AverageGrade);
            WriteResult("Highest", stats.HighestGrade);
            WriteResult("Lowest",stats.LowestGrade);
            WriteResult("Grade", stats.LetterGrade);
            WriteResult("My opinion", stats.Description);

            //GradeBook book2 = book; //= new GradeBook();
            //book2.AddGrade(75);

            //book2.grades

            //ctro cw tabx2

        }

        //static void OnNameChanged(string existingName, string newName) //subscriber of an event
        //{
        //    Console.WriteLine($"Grade book changing name from {existingName} to {newName}");

        //}
        //static void OnNameChanged(object sender, NameChangedEventArgs args)
        //{
        //    Console.WriteLine($"Grade book changing name from {args.ExistingName} to {args.NewName}");

        //}



        //static void WriteResult(string description, int  result)
        //{ //overload methods
        //    Console.WriteLine(description + ": " + result);
        //}
        static void WriteResult(string description, string result)
        {
            
            Console.WriteLine($"{description}: {result}", description, result);
        }
        static void WriteResult(string description, float result)
        {
            //Console.WriteLine(description + ": " + result);
            //Console.WriteLine("{0}: {1}", description, result);
            Console.WriteLine($"{description}: {result:F2}", description, result);
        }
    }

}
