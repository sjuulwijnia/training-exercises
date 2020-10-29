using System;

namespace HumanCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var simon = new Simon();
            var willem = new Willem();

            Berekening berekening = null;
            berekening += simon.Add;
            berekening += simon.Divide;
            berekening += simon.Add;
            berekening += simon.Multiply;
            berekening += simon.Subtract;
            berekening += simon.Subtract;
            berekening += simon.Divide;
            berekening += simon.Subtract;

            willem.RekenUit(berekening, 25, 5);
        }
    }
}
