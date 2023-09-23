using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using Microsoft.VisualBasic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
         if (n == 0)
            {
                throw new ArgumentException("'n' cannot be zero.");
            }
            int remainder = startNumber % n;

            int nextNumber = startNumber + (n - remainder);
            return nextNumber;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            
            for (int i = 0; i < businesses.Length; i++)
            {
                
                if (businesses[i].TotalRevenue == 0)
                {
                    
                    businesses[i].Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return false; 
            }

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    return false; 
                }
            }

            return true; 
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length < 2)
            {
                return 0; 
            }

            int sum = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }

            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
            {
                return ""; 
            }

            List<string> nonEmptyWords = new List<string>();

            foreach (string word in words)
            {
                string trimmedWord = word.Trim();

                if (!string.IsNullOrEmpty(trimmedWord))
                {
                    nonEmptyWords.Add(trimmedWord);
                }
            }

            if (nonEmptyWords.Count == 0)
            {
                return ""; 
            }

            string sentence = string.Join(" ", nonEmptyWords);

            if (!string.IsNullOrEmpty(sentence))
            {
                sentence = char.ToUpper(sentence[0]) + sentence.Substring(1) + "."; 
            }

            return sentence;
        }




        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null || elements.Count < 4)
            {
                return new double[0]; 
            }

            List<double> result = new List<double>();
            for (int i = 3; i < elements.Count; i += 4)
            {
                result.Add(elements[i]);
            }

            return result.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            if (nums == null || nums.Length < 2)
            {
                return false; 
            }

            HashSet<int> seen = new HashSet<int>();
            foreach (int num in nums)
            {
                int complement = targetNumber - num;
                if (seen.Contains(complement))
                {
                    return true; 
                }
                seen.Add(num);
            }

            return false; 
        }

    }
}
