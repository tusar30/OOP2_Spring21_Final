using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interface_Lab2
{
    class Radio : Mphone, RadioIF, PlayerIF
    {
        public double channel { get; set; }
        public string player { get; set; }

        public Radio(string player, double channel)
        {
            this.player = player;
            this.channel = channel;
        }


        public void change()
        {
        }

        public override void play(bool on)
        {
            Console.WriteLine("Radio Playing..!!..");
            showInfo();
        }

        public override void playnxt()
        {
            if (channel <= 105.89)
            {
                channel += 0.10;
            }
            else Console.WriteLine("Can't going next Channel!");
            showInfo();
        }

        public override void playpre()
        {
            if (channel >= 0.10)
            {
                channel -= 0.10;
            }
            else Console.WriteLine("Can't going previous Channel!");
            showInfo();
        }
        public void showInfo()
        {
            Console.WriteLine("Channel : " + channel);
        }

        public void reTune(double frequency)
        {

        }
        public override void Switch(bool on)
        {
            Console.WriteLine("Radio Playing..!!..");
            showInfo();
        }
        public override void setVolume(int loudness)
        {
            Console.WriteLine("Volume : " + loudness);
        }
    }
}