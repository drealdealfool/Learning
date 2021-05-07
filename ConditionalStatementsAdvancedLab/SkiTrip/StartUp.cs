
namespace SkiTrip
{
using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int daysStay = int.Parse(Console.ReadLine());
            string typeOfRoom = Console.ReadLine();
            string rating = Console.ReadLine();
            int nightsStay = daysStay - 1;
            double price = 0;
            double afterDiscount = 0;

            switch (typeOfRoom)
            {
                case "room for one person":
                    price = 18.00;
                    afterDiscount = 1;
                    break;

                case "apartment":
                    price = 25.00;
                    if (nightsStay < 10)
                    {
                        afterDiscount = 0.70;
                    }
                    else if (10 <= nightsStay && nightsStay <= 15)
                    {
                        afterDiscount = 0.65;
                    }
                    else if (nightsStay > 15)
                    {
                        afterDiscount = 0.50;
                    }
                    break;

                case "president apartment":
                    price = 35.00;
                    if (nightsStay < 10)
                    {
                        afterDiscount = 0.90;
                    }
                    else if (10 <= nightsStay && nightsStay <= 15)
                    {
                        afterDiscount = 0.85;
                    }
                    else if (nightsStay > 15)
                    {
                        afterDiscount = 0.80;
                    }
                    break;

            }

            if (rating == "positive")
            {
                Console.WriteLine($"{(nightsStay * price * afterDiscount * 1.25):f2}");
            }
            else if(rating == "negative")
            {
                Console.WriteLine($"{(nightsStay * price * afterDiscount * 0.90):f2}");
            }

        }
    }
}
