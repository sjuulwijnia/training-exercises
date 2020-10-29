using ISO;
using System;

namespace DoomsdayPreppers
{
    public class Valkuil : IDetectieLusApparaat
    {
        public void Activeer()
        {
            Open();
        }

        public void Deactiveer()
        {
            Dicht();
        }

        public void Dicht()
        {
            Console.WriteLine("De valkuil met spiezen gaat dicht.");
        }

        public void Open()
        {
            Console.WriteLine("De valkuil met spiezen gaat open!");
        }
    }
}
