using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkTestApp.Attributes;

namespace BenchmarkTestApp
{
    [UserServiceAttributes(Name = "Role")]
    public class RoleService:ITestService 
    {
    }
}
