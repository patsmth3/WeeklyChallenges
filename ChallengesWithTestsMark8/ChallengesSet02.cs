using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Count() % 2 == 0;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            return numbers == null || numbers.Count() < 1 ? 0 : numbers.Max() + numbers.Min();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            var list = new List<int>() { str1.Length, str2.Length };
            return list.Min();
        }

        public int Sum(int[] numbers)
        {
            return numbers == null ? 0 : numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
           return numbers == null ? 0 : numbers.Where(x=> x % 2 == 0).Sum();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            return numbers != null && numbers.Where(x => x % 2 == 0).Sum() % 2 != 0;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            return number <= 0 ? 0 : number / 2;
        }
    }
}
