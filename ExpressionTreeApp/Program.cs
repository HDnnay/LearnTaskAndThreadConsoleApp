// See https://aka.ms/new-console-template for more information

using ExpressionTreeToString;
using System.Linq.Expressions;
var iniArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
Expression<Func<int, bool>> lambda = num => num >5;
Expression<Func<int,int>> lambda2 = num=> num+num-1;
var resutl = iniArray.Select(lambda2.Compile());
Console.WriteLine(lambda2.ToString("Object notation","C#"));
foreach (var item in resutl)
{
    Console.WriteLine(item);
}
Console.ReadLine();