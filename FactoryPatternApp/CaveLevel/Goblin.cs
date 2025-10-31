using FactoryPatternApp.Common;

namespace FactoryPatternApp.CaveLevel
{
    public class Goblin : IEnemy
    {
        public Goblin()
        {
            Console.WriteLine("创建Goblin");
        }
        public  void ToDoSomething()
        {
            Console.WriteLine("GoblinToDo攻击");
        }
    }
}