using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeBook : GradeTracker   //internal domyslnie jak nic nie ma, dostepne tylko w jednym assembly
    {
        //constructor ctor

        public GradeBook()
        {
            _name = "Empty";
            grades = new List<float>();

        }

        public override GradeStatististics ComputeStatistics()
        {
            Console.WriteLine("Gradebook::ComputeStatistics");
            GradeStatististics stats = new GradeStatististics();

            //stats.HighestGrade = 0;

            float sum = 0;
            foreach (float grade in grades)
            {
                //if (grade > stats.HighestGrade)
                //{
                //    stats.HighestGrade = grade;

                //}
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                //stats.LowestGrade = Math.Min(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);

                sum = sum + grade;  //lub sum += grade
            }

            stats.AverageGrade = sum / grades.Count;

            return stats;

        }

        public override void WriteGrades(TextWriter destination)
        {
            
            for (int i = 0; i < grades.Count; i++)
            {
                
                destination.WriteLine(grades[i]);
            
            }
        }

        public override void AddGrade(float grade)  //method
        {
            grades.Add(grade);  //.Clear .Sort


        }

        //public string Name; //field

        //property:


        //private List<float> grades;
        protected List<float> grades;


    }
}
