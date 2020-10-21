using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1QuestionThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kost van uw produkt -> ");
            decimal costProduct = decimal.Parse(Console.ReadLine());

            Console.Write("hoeveel betaal je -> ");
            decimal moneyGiven = decimal.Parse(Console.ReadLine());

            decimal change = moneyGiven - costProduct;

            decimal twentyCent = 0, tienCents = 0, fiveCents = 0, oneCent = 0, twoCent = 0, fiftyCent = 0, oneEuro = 0;

            while (change >= 1m)
            {
                oneEuro = Math.Truncate((change / 1m));
                change = change % 1m;
            }

            while (change >= 0.50m)
            {
                fiftyCent = Math.Truncate((change / 0.50m));
                change = change % 0.50m;
            }

            while (change >= 0.20m)
            {
                twentyCent = Math.Truncate((change / 0.20m));
                change = change % 0.20m;
            }

            while (change >= 0.10m)
            {
                tienCents = Math.Truncate((change / 0.10m));
                change = change % 0.10m;
            }

            while (change >= 0.05m)
            {
                fiveCents = Math.Truncate((change / 0.05m));
                change = change % 0.05m;
            }

            while (change >= 0.02m)
            {
                twoCent = Math.Truncate((change / 0.02m));
                change = change % 0.02m;
            }

            while (change >= 0.01m)
            {
                oneCent = Math.Truncate((change / 0.01m));
                change = change % 0.01m;
            }



            Console.WriteLine("{0} Twenty cent, {1} ten cents, {2} five cents, {3} one cent, {4}two cents, {5}fifty Cent, {6}one Euro ", twentyCent,
                tienCents, fiveCents, oneCent, twoCent, fiftyCent, oneEuro);


        }
    }
}
