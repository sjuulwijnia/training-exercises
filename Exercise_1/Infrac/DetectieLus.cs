using ISO;
using System;
using System.Collections.Generic;

namespace Infrac
{
    public class DetectieLus
    {
        private readonly IList<IDetectieLusApparaat> aangeslotenApplicaties = new List<IDetectieLusApparaat>();

        public void SluitApplicatieAan(IDetectieLusApparaat applicatie)
        {
            aangeslotenApplicaties.Add(applicatie);
        }

        public void Trigger()
        {
            Console.WriteLine("Hmm. We zien iets... Daar moeten we op reageren!");

            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Activeer alle aangesloten applicaties!");

            Console.BackgroundColor = ConsoleColor.Green;
            foreach (var aangeslotenApplicatie in aangeslotenApplicaties)
            {
                aangeslotenApplicatie.Activeer();
            }

            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Klaar!");
        }
    }
}
