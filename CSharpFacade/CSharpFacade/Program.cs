using System;

namespace CSharpFacade
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new CarFacade();

            var form = new CarOrderForm
            {
                AirbagUpgrade = true,
                BluetoothUpgrade = true,
                EngineType = "V4",
                FiveYearMaintenance = true,
                SunroofUpgrade = false,
                SeatWarmerUpgrade = false,
                TireStyle = "All Season",
                UpgradeToSuperchargeEngine = false
            };

            car.BuildaCar(form);

            // Wait for user
            Console.ReadKey();
        }
    }
}
