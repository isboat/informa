using System.Collections.Generic;

namespace Informa.FizzBuzz
{
    public interface IFizzBuzzService
    {
        void PrintOutput(string range);

        OutPutRange ParseInput(string input);

        bool IsModFifteen(int next);

        bool IsModFive(int next);

        bool IsModThree(int next);
    }
}