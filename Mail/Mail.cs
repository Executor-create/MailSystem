using System;
using System.Collections.Generic;
using System.Linq;

namespace MainMail
{
    class Mail
    {
        private static List<Parcel> parcels = new List<Parcel>();
        static void Main(string[] args)
        {
            Menu();

            Console.ReadKey();
        }

        private static void Menu()
        {
            int menuIndex = 0;

            do
            {

                Console.WriteLine("1.OrderParcel\n2.Info about parcels");

                var answer = Console.ReadLine();

                try
                {
                    menuIndex = Convert.ToInt32(answer);
                }
                catch
                {
                    Console.WriteLine("Enter correct value");
                }

                switch (menuIndex)
                {
                    case 1:
                        OrderParcel();
                        break;
                    case 2:
                        InfoParcels();
                        break;
                }

            } while (menuIndex != 3);
        }

        private static void OrderParcel()
        {
            Console.WriteLine("Enter name of parcel");
            string name = Console.ReadLine();

            Console.WriteLine("Enter volume of parcel");
            float volume = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter price of parcel");
            float price = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter identify of parcel");
            int identify = Convert.ToInt32(Console.ReadLine());

            parcels.Add(new Parcel(name, volume, price, identify));
        }

        private static void InfoParcels()
        {
            var sortedParcels = parcels.OrderByDescending(parcel => parcel.Volume()).ThenBy(parcel => parcel.Price());

            foreach(Parcel parcels in sortedParcels)
            {
                Console.WriteLine($"{parcels.Name()} has volume: {parcels.Volume()} and price: {parcels.Price()}");
            }
        }
    }
}