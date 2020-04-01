using System;
using System.Collections.Generic;

namespace Bus_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            bus miniBus = new bus();
            miniBus.Name = "Renault";
            //miniBus.Seat = 20;
            int x = miniBus.run();

            int y = miniBus.fuelRequiredToTravel(7);
            Console.WriteLine("The bus name is {0}, the total number of seat in the bus is and the running speed is ",
                miniBus.Name);
            Console.WriteLine(y);

            Console.ReadLine();
        }
    }

    class bus
    {
        private String busName;
        private int busNumber;

        public string Name   // property
        {
            get { return busName; }
            set { busName = value; }
        }
        public int number  // property
        {
            get { return busNumber; }
            set { busNumber = value; }
        }



        public int run()
        {
            int runningSpeed = 0;
            do
            {
                if (runningSpeed > 10)
                {
                    Console.WriteLine("The bus is running in low speed ");
                }
                else if (runningSpeed >= 35)
                {
                    Console.WriteLine("The bus is in the midium spped ");
                }
                else if (runningSpeed >= 60 && runningSpeed <= 80)
                {
                    Console.WriteLine("the bus is running at {0} speed.This is high speed ", runningSpeed);
                }

            } while (runningSpeed != 0);

            return runningSpeed;
        }

        public int fuelRequiredToTravel(int traveldistanceInkilometers)
        {
            int neededGasPerKilo = 6;
            int requiredGastoDriveTheBus = traveldistanceInkilometers * neededGasPerKilo;

            
            return requiredGastoDriveTheBus;
        }


        //var Seats = new List<int>();
        List<int> Seats = new List<int>();
        Random random = new Random();
        bool emptySeat = true;

        public int eachPassengerSeatNumber()
        {
            int randomSeat = random.Next(1, 30);
            for (int i = 0; i <= Seats.Count - 1; i++)
            {
                if (Seats[i] == randomSeat)
                {
                    emptySeat = false;
                }
            }
            if (emptySeat == true)
            {
                Seats.Add(randomSeat);
            }
            return randomSeat;

        }
    }
}
