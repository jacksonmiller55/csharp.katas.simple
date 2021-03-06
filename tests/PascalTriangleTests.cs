﻿using System;
using Basic.Katas;
using NUnit.Framework;

namespace Basic.Katas.Tests
{
    [TestFixture]
    public class PascalTriangleTest
    {
        [TestCase(0, new int[] { 1 })]
        [TestCase(1, new int[] { 1, 1 })]
        [TestCase(2, new int[] { 1, 2, 1 })]
        [TestCase(3, new int[] { 1, 3, 3, 1 })]
        [TestCase(4, new int[] { 1, 4, 6, 4, 1 })]
        public void TestRow(int row, int[] expected)
        {
            Assert.That(PascalTriangle.getPascalRow(row), Is.EqualTo(expected));
        }

        [TestCase(6000000)]
        [TestCase(5000001)]
        [TestCase(-1000)]
        [TestCase(-1)]
        public void TestConstraints(int row)
        {
            var exception = Assert.Throws<ArgumentOutOfRangeException>(() => PascalTriangle.getPascalRow(row));
            string expectedMessage = string.Format("Should be between 0 and 5000000 inclusive.{0}Parameter name: n", Environment.NewLine);
            Assert.That(exception.Message, Is.EqualTo(expectedMessage));
        }

    }
}
