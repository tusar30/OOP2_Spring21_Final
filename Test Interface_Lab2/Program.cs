using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interface_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Mphone r1 = new Radio("FM Radio", 89.06);
            Mphone r2 = new Radio("FM Radio", 101.01);
            r1.play(true);
            r1.playnxt();
            Console.WriteLine();
            r2.play(true);
            r2.playpre();
            Console.WriteLine();

            Songs m1 = new Songs("Never Lie to me", "Benson", 2019, 200);
            Songs m2 = new Songs("Hello", "Lionel Richie", 2020, 280);
            Songs m3 = new Songs("Oniket Prantor", "Artcell", 2016, 307);
            Mphone ph = new Player("Music Player", m1);
            ph.add(m1, m2, m3);
            ph.play(true);
            ph.playnxt();
            Console.WriteLine();
            ph.playnxt();
            Console.WriteLine();
            ph.playnxt();
            Console.WriteLine();
            ph.playpre();
        }
    }
}