using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[assembly: Parallelize(Workers = 40, Scope = ExecutionScope.MethodLevel)]

namespace TestProject.MSTest.Sample
{
    public class TestEnvironment : IDisposable
    {
        protected int indicator = 0;

        public TestEnvironment()
        {
            //indicator = 0;
            Console.WriteLine($"ctor Test Environment - {indicator}");
        }

        public void Dispose()
        {
            Console.WriteLine($"disponse Test Environment - {indicator}");
        }
    }
}
