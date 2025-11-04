using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Engines;

namespace BenchmarkTestApp
{

    //[SimpleJob(RunStrategy.Monitoring,iterationCount:1000,invocationCount:1)]
    public class TestStrig
    {
        private const string sampleString = "Hello, World! This is a Sample String for Benchmarking.";
        //[Benchmark]
        public  void ToLower()
        {
            var result = sampleString.ToLower();
            result = "hello, world! this is a sample string for benchmarking.";
            Console.WriteLine(result);
        }
        //[Benchmark]
        public static void StrigEquals()
        {
            var result = string.Equals(sampleString, "hello, world! this is a sample string for benchmarking.", StringComparison.OrdinalIgnoreCase);
            Console.WriteLine(result);
        }
    }
}
