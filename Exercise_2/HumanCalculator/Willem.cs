using System;

namespace HumanCalculator
{
    delegate int Berekening(int a, int b);

    class Willem
    {
        public void RekenUit(Berekening berekening, int start, int modifier)
        {
            int result = start;
            foreach (Berekening invocation in berekening.GetInvocationList())
            {
                Console.WriteLine($"Willem rekent! ({invocation.Method.Name})");

                result = invocation(result, modifier);
            }

            Console.WriteLine($"Willem Klein roept: het antwoord is {result}!");
        }
    }
}
