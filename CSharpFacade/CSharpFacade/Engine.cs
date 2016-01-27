using System;

namespace CSharpFacade
{
    public class Engine
    {
        public void EngineType(string engineType)
        {
            Console.WriteLine("Engine Type: {0}", engineType);
        }

        public void SuperchargeUpgrade()
        {
            Console.WriteLine("SuperCharged Engine Upgrade");
        }
    }
}