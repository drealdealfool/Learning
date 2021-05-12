
namespace HotelRoom
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsStay = int.Parse(Console.ReadLine());
            double studioPrice = 0;
            double studioCost = 0;
            double apartmentPrice = 0;
            double apartmentCost = 0;

            switch (month)
            {
                case "May":
                case "October":
                    studioPrice = 50;
                    studioCost = studioPrice * nightsStay;
                    if (nightsStay > 7 && nightsStay <= 14)
                    {
                        studioCost = studioCost * 0.95;
                    }
                    else if (nightsStay > 14)
                    {
                        studioCost = studioCost * 0.70;
                    }

                    apartmentPrice = 65;
                    apartmentCost = apartmentPrice * nightsStay;
                    if (nightsStay > 14)
                    {
                        apartmentCost = apartmentCost * 0.90;
                    }
                    break;

                case "June":
                case "September":
                    studioPrice = 75.20;
                    studioCost = studioPrice * nightsStay;
                    if (nightsStay > 14)
                    {
                        studioCost = studioCost * 0.80;
                    }

                    apartmentPrice = 68.70;
                    apartmentCost = apartmentPrice * nightsStay;
                    if (nightsStay > 14)
                    {
                        apartmentCost = apartmentCost * 0.90;
                    }
                    break;

                case "July":
                case "August":
                    studioPrice = 76;
                    studioCost = studioPrice * nightsStay;

                    apartmentPrice = 77;
                    apartmentCost = apartmentPrice * nightsStay;
                    if (nightsStay > 14)
                    {
                        apartmentCost = apartmentCost * 0.90;
                    }
                    break;

            }

            Console.WriteLine($"Apartment: {apartmentCost:f2} lv.");
            Console.WriteLine($"Studio: {studioCost:f2} lv.");

        }
    }
}
