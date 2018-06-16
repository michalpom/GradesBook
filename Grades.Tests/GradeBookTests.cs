using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grades;

namespace Grades.Tests

{   [TestClass]
    public class GradeBookTests
    {
        [TestMethod]
        public void  CompuesHighestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);

            GradeStatististics result = book.ComputeStatistics();

            Assert.AreEqual(90, result.HighestGrade);
        }

        [TestMethod]
        public void CompuesLowestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(90);
            book.AddGrade(10);
            
            book.AddGrade(75);

            GradeStatististics result2 = book.ComputeStatistics();

            Assert.AreEqual(10, result2.LowestGrade);
        }

        [TestMethod]
        public void CompuesAverageGrade()
        {
            GradeBook book = new GradeBook();
             book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatististics result = book.ComputeStatistics();

            Assert.AreEqual(85.16, result.AverageGrade,0.01);
        }
    }
}
