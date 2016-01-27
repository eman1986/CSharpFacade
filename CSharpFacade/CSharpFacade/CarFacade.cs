using System;

namespace CSharpFacade
{
    public class CarFacade
    {
        private readonly Engine _engine = new Engine();

        private readonly Tires _tires = new Tires();

        private readonly Accessories _accessories = new Accessories();

        public void BuildaCar(CarOrderForm form)
        {
            _engine.EngineType(form.EngineType);

            if (form.UpgradeToSuperchargeEngine)
            {
                _engine.SuperchargeUpgrade();
            }

            Console.WriteLine("");
            _tires.TireStyle(form.TireStyle);

            Console.WriteLine("");
            Console.WriteLine("Accessories & Upgrade Options:");
            Console.WriteLine("----------------------------------------------");

            if (form.AirbagUpgrade)
            {
                _accessories.AirbagUpgrade();
            }

            if (form.BluetoothUpgrade)
            {
                _accessories.UpgradeToBluetoothRadio();
            }

            if (form.FiveYearMaintenance)
            {
                _accessories.FiveYearMaintenance();
            }

            if (form.SeatWarmerUpgrade)
            {
                _accessories.SeatWarmerUpgrade();
            }

            if (form.SunroofUpgrade)
            {
                _accessories.SunroofUpgrade();
            }

            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Thank You for your business. =)");
            Console.WriteLine("----------------------------------------------");
        }
    }
}