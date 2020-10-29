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
            detectieLus.ActiveerSubscribers += hek.Open;
            detectieLus.ActiveerSubscribers += lamp.Aan;
            detectieLus.ActiveerSubscribers += valkuil.Open;

            detectieLus.DeactiveerSubscribers += hek.Dicht;
            detectieLus.DeactiveerSubscribers += lamp.Uit;
            detectieLus.DeactiveerSubscribers += valkuil.Dicht;

            detectieLus.Activeer();
            detectieLus.Deactiveer();
        }
    }
}
