﻿using NUnit.Framework;
using Grades;

namespace Grades.Tests
{
    [TestFixture()]
    public class GradeBookTests
    {
        [Test()]
        public void ComputesHighestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(90, result.HighestGrade);
        }

		[Test()]
		public void ComputesLowestGrade()
		{
			GradeBook book = new GradeBook();
			book.AddGrade(10);
			book.AddGrade(90);

			GradeStatistics result = book.ComputeStatistics();
			Assert.AreEqual(10, result.LowestGrade);
		}

		[Test()]
		public void ComputesAverageGrade()
		{
			GradeBook book = new GradeBook();
			book.AddGrade(91);
			book.AddGrade(89.5f);
            book.AddGrade(75);

			GradeStatistics result = book.ComputeStatistics();
			Assert.AreEqual(85.16, result.AverageGrade, 0.01);
		}
    }
}