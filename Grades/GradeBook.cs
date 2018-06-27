﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeBook    //internal domyslnie jak nic nie ma, dostepne tylko w jednym assembly
    {
        //constructor ctor
        
        public GradeBook()
        {
            _name = "Empty";
            grades = new List<float>();

        }

        public GradeStatististics ComputeStatistics()
        {
            GradeStatististics stats= new GradeStatististics();

            //stats.HighestGrade = 0;

            float sum = 0;
            foreach(float grade in grades)
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

        public void AddGrade(float grade)  //method
        {
            grades.Add(grade);  //.Clear .Sort


        }

        //public string Name; //field

        //property:
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if(!String.IsNullOrEmpty(value))
                {
                    if (_name != value)
                    {
                        NameChangedEventArgs args = new NameChangedEventArgs();
                        args.ExistingName = _name;
                        args.NewName = value;

                        NameChanged(this, args);
                    }

                    _name = value;
                }
            }

        }
        //public NameChangedDelegate NameChanged;
        public event NameChangedDelegate NameChanged;

        private string _name;

        private List<float> grades;    



    }
}
