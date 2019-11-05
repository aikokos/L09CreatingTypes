// <copyright file="CreatingTypesTasks.cs" company="LearningCompany">
// Copyright (c) Company. All rights reserved.
// </copyright>

namespace L01CreatingTypes
{
    using System;

    /// <summary>
    /// The main CreatingTypesTasks class.
    /// Contains only FindNthRoot task.
    /// </summary>
    public class CreatingTypesTasks
    {
        /// <summary>
        /// Method for find root of degree n of number with the use of
        /// Newton iterative algorithm.
        /// </summary>
        /// <param name="a">number to which we need find root</param>
        /// <param name="n">root degree</param>
        /// <param name="precision">precision of solution</param>
        /// <returns>Returns root of degree n of number a.</returns>
        public double FindNthRoot(double a, double n, double precision)
        {
            if (n <= 0)
            {
                throw new ArgumentException("n should be greater than 0");
            }

            if (precision <= 0)
            {
                throw new ArgumentException("precision should be greater than 0");
            }

            int i = 0;
            double xkprev = 1;
            double xk = 1 / n * (((n - 1) * xkprev) + (a / Math.Pow(xkprev, n - 1)));
            while (true)
            {
                xkprev = xk;
                xk = 1 / n * (((n - 1) * xk) + (a / Math.Pow(xk, n - 1)));
                i++;
                if (i > 1000)
                {
                    throw new ArgumentException("too many iterations to find root");
                }

                if (Math.Abs(xk - xkprev) < precision)
                {
                    break;
                }
            }

            return Math.Round(xk, 2);
        }
    }
}
