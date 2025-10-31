using FactoryPatternApp.Common;

namespace FactoryPatternApp.CaveLevel
{
    public class Axe : IWeapon
    {
        public Axe()
        {
            Console.WriteLine("创建Axe");
        }

    }
}