using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interface_Lab2
{
    class Player : Mphone, PlayerIF, MusicIF
    {
        public string PlayerName { get; set; }
        Songs music { get; set; }
        public Player(string PlayerName, Songs music)
        {
            this.PlayerName = PlayerName;
            this.music = music;
        }

        public override void Switch(bool on)
        {
            if (on)
            {
                base.find(music.title);
            }
            else Console.WriteLine("Resume music....");
        }

        public override void setVolume(int loudness)
        {

        }

        public override void play(bool on)
        {
            if (on)
            {
                find(music.title);
            }
            else Console.WriteLine("Resume music");
        }

        public override void playnxt()
        {
            playnxt(music.title);
        }

        public override void playpre()
        {
            playpre(music.title);
        }
    }
}
