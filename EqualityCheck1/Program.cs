using System;

namespace EqualityCheck1
{
    class Program
    {
        // https://edabit.com/challenge/Q7g8sfg7DJq6CyMMu
        // SOLVED

        static void Main(string[] args)
        {
            var types = new EqualityChecker("0", 0);
            Console.WriteLine(types.CheckTypeAndValue());
        }
    }
}
