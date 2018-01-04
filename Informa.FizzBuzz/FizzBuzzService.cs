using System;
using System.Collections.Generic;

namespace Informa.FizzBuzz
{
    public class FizzBuzzService: IFizzBuzzService
    {
        #region Constants

        private const string FizzWord = "fizz";
        private const string BuzzWord = "buzz";
        private const string FizzBuzzWord = "fizzbuzz";

        #endregion

        public void PrintOutput(string input)
        {
            var range = this.ParseInput(input);

            // Validation check
            if (range == null)
            {
                Console.WriteLine("Input range not valid.");
                return;
            }

            for (var next = range.Start; next <= range.End; next++)
            {
                Console.Write(GenerateOutput(next) + " ");
            }
        }

        private string GenerateOutput(int next)
        {
            if (next == 0)
            {
                return next.ToString();
            }

            if (IsModFifteen(next))
            {
                return FizzBuzzWord;
            }

            if (IsModFive(next))
            {
                return BuzzWord;
            }

            return IsModThree(next) ? FizzWord : next.ToString();
        }

        public bool IsModFifteen(int next)
        {
            return next % 15 == 0;
        }

        public bool IsModFive(int next)
        {
            return next % 5 == 0;
        }

        public bool IsModThree(int next)
        {
            return next % 3 == 0;
        }

        public OutPutRange ParseInput(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return null;
            }
            
            var splits = input.Split('-');
            if (splits.Length != 2)
            {
                return null;
            }

            if (!int.TryParse(splits[0], out var start))
            {
                return null;
            }

            if (!int.TryParse(splits[1], out var end))
            {
                return null;
            }

            if (start >= end)
            {
                return null;
            }

            return new OutPutRange
            {
                Start = start,
                End = end
            };
        }
    }
}