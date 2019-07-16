using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Lab2NateSimpson
{
    class Program
    {
        static void Main(string[] args)
        {
            string repeat = "y";
             while (repeat != "n" && repeat != "N" && repeat != "No" && repeat != "no" && repeat != "NO")
                {
                    //promt user for hight, length and with and store data
                   

                    Console.WriteLine("What is the length in feet");
                    double lengthFt = double.Parse(Console.ReadLine());
                    Console.WriteLine("IF you entered only the whole feet, how many inches is after, otherwise enter '0'?");
                    double lengthIn = double.Parse(Console.ReadLine());

                    Console.WriteLine("What is the Width in feet");
                    double WidthFt = double.Parse(Console.ReadLine());
                    Console.WriteLine("IF you entered only the whole feet, how many inches is after, otherwise enter '0'?");
                    double WidthIn = double.Parse(Console.ReadLine());

                    // get area, pirimeter, area, and volume
                    double area = (lengthFt + (lengthIn / 12)) * (WidthFt + (WidthIn / 12));
                    double areaIn = ((area % 1) * 12);
                    double perimiter = (2 * (lengthFt + (lengthIn / 12)) + 2 * (WidthFt + (WidthIn / 12)));
                    double perimiterIn = ((perimiter % 1) * 12);
                    



                    //print resaults
                    Console.WriteLine("the Perimiter is " + perimiter.ToString("F0", CultureInfo.InvariantCulture) + "Ft and " + perimiterIn.ToString("F2", CultureInfo.InvariantCulture) + "In.");
                    Console.WriteLine("the Area is " + area.ToString("F0", CultureInfo.InvariantCulture) + "Ft and " + areaIn.ToString("F2", CultureInfo.InvariantCulture) + "In.");

                    Console.WriteLine(" Do you want volume as well(Y/N)?");
                    string wantV = Console.ReadLine();
                    if (wantV != "n" || wantV != "N" || wantV != "No" || wantV != "no" || wantV != "NO")
                    {
                    Console.WriteLine("What is the hight in feet");
                    double hightFt = double.Parse(Console.ReadLine());
                    Console.WriteLine("IF you entered only the whole feet, how many inches is after, otherwise enter '0'?");
                    double hightIn = double.Parse(Console.ReadLine());

                    double volume = area * (hightFt + (hightIn / 12));
                    double volumeIn = ((volume % 1) * 12);

                    Console.WriteLine("the Volume is " + volume.ToString("F0", CultureInfo.InvariantCulture) + "Ft and " + volumeIn.ToString("F2", CultureInfo.InvariantCulture) + "In.");
                    }

                    // ask if they want a repeat
                    Console.WriteLine("would you like to go again?");
                    repeat = Console.ReadLine();

                }
        }
    }
}
