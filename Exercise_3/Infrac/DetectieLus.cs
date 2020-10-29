using System;

namespace Infrac
{
    public delegate void DetectieLusDelegate();

    public class DetectieLus
    {
        public event DetectieLusDelegate ActiveerSubscribers;
        public event DetectieLusDelegate DeactiveerSubscribers;

        public void Activeer()
        {
            Console.WriteLine("Hmm. We zien iets... Daar moeten we op reageren!");

            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Activeer alle aangesloten applicaties!");

            Console.BackgroundColor = ConsoleColor.Green;
            ActiveerSubscribers();

            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Alles is geactiveerd!");

            Console.ResetColor();
            Console.WriteLine();
        }

        public void Deactiveer()
        {
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("En we zetten alles weer uit...");

            Console.BackgroundColor = ConsoleColor.Green;
            DeactiveerSubscribers();

            Console.ResetColor();
            Console.WriteLine("Alles is gedeactiveerd!");

            Console.WriteLine();
        }
    }
}
