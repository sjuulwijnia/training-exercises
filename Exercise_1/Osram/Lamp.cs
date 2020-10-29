using ISO;
using System;

namespace Osram
{
    public class Lamp : IDetectieLusApparaat
    {
        public void Activeer()
        {
            Aan();
        }

        public void Deactiveer()
        {
            Uit();
        }

        public void Aan()
        {
            Console.WriteLine("De lamp gaat aan!");
        }

        public void Uit()
        {
            Console.WriteLine("De lamp gaat uit.");
        }
    }
}
