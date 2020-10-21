using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1QuestionTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstScore;
            Console.WriteLine("First score?");
            firstScore = Convert.ToInt32(Console.ReadLine());

            double secondScore;
            Console.WriteLine("second score?");
            secondScore = Convert.ToInt32(Console.ReadLine());

            double thirdscore;
            Console.WriteLine("third score?");
            thirdscore = Convert.ToInt32(Console.ReadLine());

            double fourthScore;
            Console.WriteLine("fourth score?");
            fourthScore = Convert.ToInt32(Console.ReadLine());

            double sum;
            sum = 0;
            sum = firstScore + secondScore + thirdscore + fourthScore;
            //Console.WriteLine("The sum is: " + sum);

            double average;
            average = sum / 4;
            Console.WriteLine("The average is: "+ average);

            //double percentage=0;

            Console.WriteLine("First score in percentage is: "+ firstScore*100/10);
            Console.WriteLine("Second score in percentage is: " + secondScore * 100 / 10);
            Console.WriteLine("Third score in percentage is: " + thirdscore * 100 / 10);
            Console.WriteLine("Fourth score in percentage is: " + fourthScore * 100 / 10);






        }
    }
}
