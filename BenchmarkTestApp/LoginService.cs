using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using BenchmarkTestApp.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BenchmarkTestApp
{
    [SimpleJob(RunStrategy.Monitoring, iterationCount: 1000, invocationCount: 1)]
    public class LoginService
    {
        Dictionary<string, ITestService> dictionaryOne = new(StringComparer.OrdinalIgnoreCase);
        Dictionary<string, ITestService> dictionaryTwo = new(StringComparer.OrdinalIgnoreCase);

        private IEnumerable<ITestService> users;
        public LoginService()
        {
             users = new List<ITestService>
            {
                new UserService(),
                new RoleService()
            };
        }
        [Benchmark]
        public void TestOne()
        {

            //foreach (var user in users)
            //{
            //    var key = user.GetType().GetCustomAttribute<UserServiceAttributes>().Name;
            //    dictionaryOne.Add(key, user);
            //}
            dictionaryOne =  users.ToDictionary(t => { return t.GetType().GetCustomAttribute<UserServiceAttributes>().Name.ToLower(); }, t => t);
        }
    
        [Benchmark]
        public void TestTwo()
        {
            dictionaryTwo =  users.ToDictionary(t => { return t.GetType().GetCustomAttribute<UserServiceAttributes>().Name; }, t => t);
        }
    }
}
