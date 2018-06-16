﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Tests.Tapes
{ //testtttt
    [TestClass]
    public class TypeTests
    {

        [TestMethod]
        public void UsingArrays()
        {
            float[] grades;
            grades = new float[3];

            AddGrades(grades);

            Assert.AreEqual(89.1f, grades[1]);
        }

        private void AddGrades(float[] grades)
        {
            grades[1] = 89.1f;
        }

        [TestMethod]
        public void UppercaseString()
        {
            string name = "scott";
            name=name.ToUpper();        //nowe przypisanie, samo po = nie dziala
            Assert.AreEqual("SCOTT", name);

        }

        [TestMethod]
        public void AddDaysToDateTime()
        {
            DateTime date = new DateTime(2015, 1, 1);
            date=date.AddDays(1);   //nowe przypisanie, samo po = nie dziala
            Assert.AreEqual(2, date.Day);
        }


        [TestMethod]
        public void ValueTypesPassByValue()
        {
            int x = 46;
            IncrementNumber(x);
            Assert.AreEqual(46, x);
        }

        private void IncrementNumber(int number)
        {
            number = number + 1;
        }

        [TestMethod]
        public void ReferenceTypesPassByValue()
        {
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;
            GiveBookAName(book2);
            Assert.AreEqual("A GradeBook", book1.Name);
        }
        private void GiveBookAName(GradeBook book)
        {
            book.Name = "A GradeBook";
        }

        [TestMethod]
        public void StingComparisons()
              {
            string name1 = "Scott";
            string name2 = "scott";

            bool result = string.Equals(name1, name2, StringComparison.InvariantCultureIgnoreCase);
            Assert.IsTrue(result);

        }


        [TestMethod]
        public void IntVariablesHoldAValue()
        {
            int x1 = 100;
            Int32 x2 = x1;   // to to samo co 'int'
            x1 = 4;
            Assert.AreNotEqual(x1, x2); //not equal bo value type


        }

        [TestMethod]
        public void GradeBookVariablesHoldAReference()
        {

            
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;
            g1.Name = "Scott's grade book";
            Assert.AreEqual(g1.Name, g2.Name); //equal bo reference type
        }
    }
}