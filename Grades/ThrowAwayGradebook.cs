﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class ThrowAwayGradebook : GradeBook
    {
        public override GradeStatististics ComputeStatistics()
        {
            Console.WriteLine("ThrowAwayGradebook::ComputeStatistics");
            float lowest = float.MaxValue;
            foreach (float grade in grades)
            {
                lowest = Math.Min(grade, lowest);
            }
            grades.Remove(lowest);

            return base.ComputeStatistics();

        }
    }
}
