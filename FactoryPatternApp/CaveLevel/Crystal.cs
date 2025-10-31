using FactoryPatternApp.Common;

namespace FactoryPatternApp.CaveLevel
{
    public class Crystal : IPowerUp
    {
        public Crystal()
        {
            Console.WriteLine("创建Crystal");
        }
    }
}