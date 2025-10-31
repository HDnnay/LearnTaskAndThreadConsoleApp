
using FactoryPatternApp.CaveLevel;
using FactoryPatternApp.Common;

var elEnvironment = new CaveLevelElementFactory();
elEnvironment.SetupEnvironment();
var goblin = elEnvironment.EmEnemy;
goblin.ToDoSomething();
Console.ReadKey();
