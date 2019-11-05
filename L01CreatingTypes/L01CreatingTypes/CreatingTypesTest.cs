// <copyright file="CreatingTypesTest.cs" company="LearningCompany">
// Copyright (c) Company. All rights reserved.
// </copyright>

namespace L01CreatingTypes
{
    using System;
    using NUnit.Framework;

    /// <summary>
    /// The tests for CreatingTypesTasks class.
    /// </summary>
    public class CreatingTypesTest
    {
        [Test]
        [TestCase(1, 5, 0.0001, ExpectedResult = 1)]
        [TestCase(8, 3, 0.0001, ExpectedResult = 2)]
        [TestCase(0.001, 3, 0.0001, ExpectedResult = 0.1)]
        [TestCase(0.04100625, 4, 0.0001, ExpectedResult = 0.45)]
        [TestCase(8, 3, 0.0001, ExpectedResult = 2)]
        [TestCase(0.0279936, 7, 0.0001, ExpectedResult = 0.6)]
        [TestCase(0.0081, 4, 0.1, ExpectedResult = 0.35)]
        [TestCase(-0.008, 3, 0.1, ExpectedResult = -0.24)]
        [TestCase(0.004241979, 9, 0.00000001, ExpectedResult = 0.54)]

        /// <summary>
        /// Method to test basic test cases for FindNthRoot method.
        /// </summary>
        /// <param name="a">number to which we need find root</param>
        /// <param name="n">root degree</param>
        /// <param name="precision">precision of solution</param>
        /// <returns>Returns root of degree n of number a.</returns>
        public double FindNthRootTest(double a, double n, double precision)
        {
            CreatingTypesTasks t = new CreatingTypesTasks();
            return t.FindNthRoot(a, n, precision);
        }

        [TestCase(-0.01, 2, 0.0001)]
        [TestCase(0.01, -2, 0.0001)]
        [TestCase(0.01, 2, -1)]

        /// <summary>
        /// Method to test exceptional cases of FindNthRoot method.
        /// </summary>
        /// <param name="a">number to which we need find root</param>
        /// <param name="n">root degree</param>
        /// <param name="precision">precision of solution</param>
        public void TestFindNthRootThrows(double a, double n, double precision)
        {
            CreatingTypesTasks t = new CreatingTypesTasks();
            Assert.That(() => t.FindNthRoot(a, n, precision), Throws.TypeOf<ArgumentException>());
        }
    }
}