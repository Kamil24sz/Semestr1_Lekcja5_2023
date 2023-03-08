using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatoryLogiczne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Operatory logiczne
            //  >  - większość
            //  <  - mniejszość
            //  ==  - równość
            //  !=  - nie równość
            //  >=  - większy bądź równy
            //  <=  - mniejszy bądź równy

            //trudniejsze operatory
            // &&  -  i - wszystkie warunki muszą zostać spełnione    prawda && prawda = prawda     prawda && fałsz = fałsz
            // ||  -  lub - którykolwiek z warunków musi zostać spełniony      prawda && fałsz = prawda   fałsz && fałsz = fałsz
            //  !  -  przeciwieństwo   !prawda = fałsz     !fałsz = prawda;

            bool wynik = 70 == 70 || 21 != 21 || false;
            Console.WriteLine(wynik);

            // inkrementacja i dekrementacja

            int x = 1;

            //x = x + 1;    =>    x++;
            //x = x - 1;    =>    x--;

            x++;
            Console.WriteLine(x);

            Console.ReadLine();
        }
    }
}
