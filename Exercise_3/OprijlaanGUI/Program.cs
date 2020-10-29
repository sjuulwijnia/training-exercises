using DoomsdayPreppers;
using Heras;
using Infrac;
using Osram;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OprijlaanGUI
{
    class Program
    {
        static DetectieLus detectieLus;
        static Button detectieLusKnop;
        static bool isActivated = false;
        static bool isDeactivating = false;

        static void Main(string[] args)
        {
            Hek hek = new Hek();
            Lamp lamp = new Lamp();
            Valkuil valkuil = new Valkuil();

            detectieLus = new DetectieLus();
            detectieLus.ActiveerSubscribers += hek.Open;
            detectieLus.ActiveerSubscribers += lamp.Aan;
            detectieLus.ActiveerSubscribers += valkuil.Open;

            detectieLus.DeactiveerSubscribers += hek.Dicht;
            detectieLus.DeactiveerSubscribers += lamp.Uit;
            detectieLus.DeactiveerSubscribers += valkuil.Dicht;

            Form formulier = new Form();
            formulier.Height = 340;
            formulier.Width = 315;

            detectieLusKnop = new Button();
            detectieLusKnop.MouseEnter += ActiveerKnop_Click;
            detectieLusKnop.MouseLeave += DeactiveerKnop_Click;
            detectieLusKnop.Location = new Point(50, 50);
            detectieLusKnop.Text = "DETECTIELUS";
            detectieLusKnop.Height = 200;
            detectieLusKnop.Width = 200;

            formulier.Controls.Add(detectieLusKnop);

            formulier.ShowDialog();
        }

        private static async void DeactiveerKnop_Click(object sender, EventArgs e)
        {
            if (!isActivated || isDeactivating)
            {
                return;
            }

            isDeactivating = true;

            for (var i = 0; i < 5 && isDeactivating; i++)
            {
                detectieLusKnop.BackColor = Color.Orange;
                await Task.Delay(100);

                if (isDeactivating)
                {
                    detectieLusKnop.BackColor = Color.White;
                    await Task.Delay(100);
                }
            }

            if (isDeactivating)
            {
                detectieLusKnop.BackColor = Color.White;
                detectieLus.Deactiveer();

                isActivated = false;
                isDeactivating = false;
            }
        }

        private static void ActiveerKnop_Click(object sender, EventArgs e)
        {
            if (isActivated && !isDeactivating)
            {
                return;
            }

            detectieLusKnop.BackColor = Color.Red;

            if (!isActivated)
            {
                detectieLus.Activeer();
            }

            isActivated = true;
            isDeactivating = false;
        }
    }
}
