using ISO;
using System;

namespace Heras
{
    public class Hek : IDetectieLusApparaat
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
            Console.WriteLine("Het hek gaat dicht.");
        }

        public void Open()
        {
            Console.WriteLine("Het hek gaat open!");
        }
    }
}
