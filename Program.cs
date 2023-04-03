using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klaas2
{
    class Rechner
    {
        public int Addition(int einzahl,int anderezahl)
        {
            return einzahl + anderezahl;
        }
        public int Subtrahiere(int einzahl,int anderzahl)
        {
            return einzahl - anderzahl;
        }       
        static void Main(string[] args)
        {
            Console.WriteLine("zahl1");
            int zahl1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("zahl2");
            int zahl2= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nitte wähle die gewünschte Reachenoperation");
            Console.WriteLine("?n multiplikation +  \n Division / \n Addition ");
            string Zeichen=Console.ReadLine();
            Rechner meinRechner=new Rechner();
            int erg_add = meinRechner.Addition(zahl1, zahl2);
            if (Zeichen == "+")
            {
                Console.WriteLine("die summe aus" + zahl1 + "und" + zahl2 + "ist " + meinRechner.Addition(zahl1, zahl2));


            }
            else if (Zeichen == "-")
            {
                Console.WriteLine("die suptraktion aus" + zahl1 + "und" + zahl2 + "ist " + meinRechner.Subtrahiere(zahl1, zahl2));
            }
            else if (Zeichen == "*")
            {
                Console.WriteLine("die summe aus" + zahl1 + "und" + zahl2 + "ist " + meinRechner.Addition(zahl1, zahl2));
            }

        }

       
    }
}
