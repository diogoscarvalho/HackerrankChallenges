using static System.Collections.Specialized.BitVector32;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;

namespace Booking.com
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var cars = new List<long>() { 4,1,2,3,10 };
            //var distance = SecondChallenge.CarParkingRoof(cars, 4);

            //Console.WriteLine(distance);

            var config = DefaultConfig.Instance;
            var summary = BenchmarkRunner.Run<Bentchmarks>(config, args);


            //var duplicates = CountDuplicateElements.CountDuplicate(new List<int> { 1, 2, 3, 4, 5, 1, 3, 6, 1 });

            //Console.WriteLine(duplicates);

            //var a = ThirdChallenge.AwardTopKHotels("breakfast beach citycenter location metro view staff price", "Not", new List<int> { 5, 1, 2, 1, 1, 2, 5 }, new List<string>
            //{
            //    "This hotel has a nice view of the citycenter. The location is perfect.",
            //    "The breakfast is ok. Regarding location, it is quite far from citycenter but price is cheap so it is worth.",
            //    "Location is excellent, 5 minutes from citycenter. There is also a metro station very close to the hotel.",
            //    "Good price but I couldn't take my dog and there were other guests with dogs!",
            //    "Very friendly staff and good cost-benefit ratio. Its location is a bit far from citycenter."
            //}, 2);


            Console.ReadKey();
        }
    }
}
