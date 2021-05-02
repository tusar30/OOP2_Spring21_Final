using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interface_Lab2
{
    abstract class Mphone : PlayerIF
    {
        public abstract void playnxt();
        public abstract void playpre();
        public abstract void Switch(bool on);
        public abstract void setVolume(int loudness);
        public abstract void play(bool on);

        Songs[] Songs;
        public int total { get; set; }

        public Mphone()
        {
            Songs = new Songs[1000];
        }

        public void add(params Songs[] musics)
        {
            if (total < 1000)
            {
                foreach (Songs music in musics)
                {
                    this.Songs[total++] = music;
                }
            }
            else
            {
                Console.WriteLine("Not enough Space!");
            }
        }

        public void musicList()
        {
            for (int i = 0; i < total; i++)
            {
                this.Songs[i].showInfo();
            }
        }

        public void find(string title)
        {
            foreach (var music in Songs)
            {
                if (music.title.Equals(title))
                {
                    Console.WriteLine("Playing Music..#..");
                    music.showInfo();
                    break;
                }
            }
        }
        public void playpre(string title)
        {
            for (int i = 0; i < total; i++)
            {
                if (i >= 0)
                {
                    if (Songs[i].title.Equals(title))
                    {
                        find(Songs[i - 1].title);
                    }
                }

            }
        }

        public void playnxt(string title)
        {
            for (int i = 0; i < total; i++)
            {
                if (i < total)
                {
                    if (Songs[i].title.Equals(title))
                    {
                        find(Songs[i + 1].title);
                    }
                }
            }
        }


    }
}