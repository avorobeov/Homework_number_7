using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_number_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberPeople;
            int visitTime = 10;
            int numberHours;
            int numberMinutes;
            int numberMinutesInHour = 60;

            Console.WriteLine("Введите кол-во старушек: ");
            numberPeople = Convert.ToInt32(Console.ReadLine());

            numberHours = numberPeople * visitTime / numberMinutesInHour;
            numberMinutes = numberPeople * visitTime % numberMinutesInHour;

            Console.WriteLine($"Вы должны отстоять в очереди {numberHours} часа и {numberMinutes} минут.");
            Console.ReadKey();
        }
    }
}
