using DoomsdayPreppers;
using Heras;
using Infrac;
using Osram;

namespace Oprijlaan
{
    class Program
    {
        static void Main(string[] args)
        {
            Hek hek = new Hek();
            Lamp lamp = new Lamp();
            Valkuil valkuil = new Valkuil();

            DetectieLus detectieLus = new DetectieLus();
            detectieLus.SluitApplicatieAan(hek);
            detectieLus.SluitApplicatieAan(lamp);
            detectieLus.SluitApplicatieAan(valkuil);

            detectieLus.Trigger();
        }
    }
}
