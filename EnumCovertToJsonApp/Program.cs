using System.Text.Json;
using System.Text.Json.Serialization;

var json = JsonSerializer.Deserialize<Income[]>(File.ReadAllText("test.json"), new JsonSerializerOptions()
{
    PropertyNameCaseInsensitive = true,
    Converters = { new JsonStringEnumConverter() }

});
//如果Json中Type类型是数字如：{"type":"677","Amount":34234},也可以转换成功，677会被转换为IncomeCategory中对应的枚举值
foreach (var income in json)
{
    Console.WriteLine($"{income.Type}: {income.Amount}");
}
//例如1："1234"按常理说我们在IncomeCategory未定义，之际转换应该不成功，但是呢？
IncomeCategory test1 = Enum.Parse<IncomeCategory>("1234");
//但是这里转换成功了，test1的值就是1234
//这说明Enum.Parse在转换时，如果字符串无法匹配到枚举定义的名称，则会尝试将其作为枚举的基础类型进行转换
Console.WriteLine(test1);
//例如2：这里"test"无法转换为IncomeCategory中定义的任何名称或数字，因此会抛出异常
////IncomeCategory test2 = Enum.Parse<IncomeCategory>("test");
//例如3：将数字字符串转换为枚举检测是否合法
Console.WriteLine(Enum.IsDefined(typeof(IncomeCategory),"1234")); // False
#region  new JsonStringEnumConverter(allowIntegerValues:false test2.json{"type": 12345,"Amount": 7000} 转换失败报错
//但是{"type": "12345","Amount": 7000} 可以转换成功，12345会被转换为IncomeCategory中对应的枚举值
var json2 = JsonSerializer.Deserialize<Income[]>(File.ReadAllText("test2.json"), new JsonSerializerOptions()
{
    PropertyNameCaseInsensitive = true,
    Converters = { new JsonStringEnumConverter(allowIntegerValues:false) }

});
foreach (var income in json2)
{
    Console.WriteLine($"{income.Type}: {income.Amount}");
}
#endregion
Console.ReadKey();
public class Income
{
    public IncomeCategory Type { get; set; }
    public double Amount { get; set; }
}
public enum IncomeCategory
{
    Salary,
    Business,
    Investment,
    Rental,
    Freelance
}
