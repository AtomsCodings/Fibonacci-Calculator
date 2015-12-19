/*****************************************************************************************************
* Page Version and Last Updated: Version 1.0 19/12/15 by A Thomas                                    *
*                                                                                                    *
* Code below makes calculations for the Fibonacci sequence.  They use the principles of the formulas *
* x(n) = x(n-1) + x(n-2), or the golden ratio formula x(n) ≈ ( phi^n - (1 - phi)^n ) / √5.           *
* n is the term and x(n) is the sequence number.                                                     *
*                                                                                                    *
* Display for this code is handled by Form1.cs                                                       *
*                                                                                                    *
* Methods in Fibonacci class: FindXnIfNBiggerThanOrEqualsZero(int nTerm),                            *
* FindXnIfNSmallerThanZero(int nTerm), GoldenRatioFormula(int nGoldenTerm),                          *
* FindNIfXnBiggerThanOrEqualsZero(int findIfNoInSequence),                                           *
* FindNIfXnSmallerThanZero(int findIfNoInSequence)                                                   *
*                                                                                                    *
* App designed for range to be term n= +/-45, and max entry to see if number is a X(n) = sequence    *
* number is +/- 2 * 10^9                                                                             *                                                                                        *
*                                                                                                    *
* Display for this code is handled by Form1.cs                                                       *
*                                                                                                    *
* The sequence has the pattern of:                                                                   * 
* (term)           n =   ...   -6   -5   -4   -3   -2   -1   0   1   2   3   4   5   6   ...         *
* (sequence no) x(n) =   ...   -8    5   -3    2   -1    1   0   1   1   2   3   5   8   ...         *
*                                                                                                    *
* More information on the Fibonacci sequence itself is available in Form2.cs                         *
*****************************************************************************************************/
using System;

namespace Fibonacci_Sequence
{
    class Fibonacci
    {
        //based on the Fibonacci sequence formula x(n) = x(n-1) + x(n-2) where n = term and x(n) = sequence number
        //works on the principle of adding two previous sequence numbers together in an interation
        public static int FindXnIfNBiggerThanOrEqualsZero(int nTerm)
        {
            int first = 0, second = 1, sequenceNoXn = 1;

            if (nTerm == 0)
                sequenceNoXn = 0;
            else if (nTerm > 1)
            {
                for (int i = 2; i <= nTerm; i++)
                {
                    sequenceNoXn = first + second;
                    first = second;
                    second = sequenceNoXn;
                }
            }
            return sequenceNoXn;
        }

        //based on the Fibonacci sequence formula x(n) = x(n-1) + x(n-2) where n = term and x(n) = sequence number
        //works on the principle of adding two previous sequence numbers together in an interation
        public static int FindXnIfNSmallerThanZero(int nTerm)
        {
            int first = 0, second = -1, sequenceNoXn = 1;

            if (nTerm < -1)
            {
                for (int i = -2; i >= nTerm; i--)
                {
                    sequenceNoXn = first + second;
                    first = second;
                    second = sequenceNoXn;
                }
                //all negative terms that are odd, give a positive number in sequence - and not negative
                if (nTerm % 2 != 0)
                    sequenceNoXn = sequenceNoXn * -1;
            }
            return sequenceNoXn;
        }

        //uses the golden ratio formula x(n) ≈ ( phi^n - (1 - phi)^n ) / √5 where n = term and x(n) = number in sequence
        //makes use of the Math.Pow(number, power) = number^power 
        //need to use convert functions in order to keep all decimal places throughout whilst using the Math.Pow function that uses double.
        public static decimal GoldenRatioFormula(int nGoldenTerm)
        {
            decimal sequenceNo = 0m;
            decimal phi = Convert.ToDecimal((1 + Math.Sqrt(5)) / 2);   //this formula finds the golden ratio = ϕ = con phistant

            if (nGoldenTerm != 0)
               sequenceNo = Convert.ToDecimal(((Math.Pow(Convert.ToDouble(phi), nGoldenTerm)) - Math.Pow(Convert.ToDouble(1 - phi), nGoldenTerm)) / Math.Sqrt(5));
            return sequenceNo;
        }

        //based on the Fibonacci sequence formula x(n) = x(n-1) + x(n-2) where n = term and x(n) = sequence number
        //works on the principle of adding two previous sequence numbers together in an interation, 
        //and then see if there is a match between user entry and sequence number
        //as some numbers repeats in the sequence, returning an array containing all relevant terms (max of 3 terms)
        //If any of the terms array elements equals -100 by end of method, then a match not found.
        public static int[] FindNIfXnBiggerThanOrEqualsZero(int findIfNoInSequence)
        {
            int first = 0, second = 1, sequenceNoXn = 0;
            int[] nTerms = new int[3] { -100, -100, -100 };

            if (findIfNoInSequence == 0)
                nTerms[0] = 0;
            if (findIfNoInSequence == 1)
            { 
                nTerms[0] = 1; nTerms[1] = 2; nTerms[2] = -1;
            }
            if (findIfNoInSequence > 1)
            {
                for (int i = 2; i <= 45; i++)
                {
                    sequenceNoXn = first + second;
                    first = second;
                    second = sequenceNoXn;
                    if (sequenceNoXn == findIfNoInSequence)
                    {
                        nTerms[0] = i;
                        //All negative terms that are odd, give a positive sequence answer - and not negative
                        //ie. terms +/- 3 gives the Fibonacci number +2 in the sequence
                        if (i % 2 != 0)
                            nTerms[1] = (i * -1);
                    }
                }
            }
            return nTerms;
        }

        //based on the Fibonacci sequence formula x(n) = x(n-1) + x(n-2) where n = term and x(n) = sequence number
        //works on the principle of adding two previous sequence numbers together in an interation, 
        //and then see if there is a match between user entry and sequence number
        //If nterm equals -100 by end of method, then number not found.
        public static int FindNIfXnSmallerThanZero(int findIfNoInSequence)
        {
            int first = 0, second = -1, sequenceNoXn = 0, nTerm = -100;

            if (findIfNoInSequence == -1)
                nTerm = 1;
            if (findIfNoInSequence < -1)
            {
                for (int i = -2; i >= -45; i--)
                {
                    sequenceNoXn = first + second;
                    first = second;
                    second = sequenceNoXn;
                    //Look for match.  All negative terms that are odd, give a positive sequence answer - and not negative - so ignore if relevant.
                    if (sequenceNoXn == findIfNoInSequence && i % 2 == 0)
                        nTerm = i;
                }
            }
            return nTerm;
        }
    }
}