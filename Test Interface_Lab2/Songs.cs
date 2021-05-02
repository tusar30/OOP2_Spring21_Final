using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interface_Lab2
{
    class Songs
    {
        private string artist { get; }
        private int duration { get; }
        public string title { get; set; }
        private int year { get; }


        public Songs() { }

        public Songs(string title, string artist, int year, int duration)
        {
            this.year = year;
            this.title = title;
            this.artist = artist;
            this.duration = duration;
        }

        void change(string title)
        {
            this.title = title;
        }

        public void showInfo()
        {
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Artist: " + artist);
            Console.WriteLine("Release Year: " + year);
            Console.WriteLine("Duration: " + duration);
        }
    }
}