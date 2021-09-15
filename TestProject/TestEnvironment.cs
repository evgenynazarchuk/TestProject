using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestProject
{
    public class TestEnvironment
    {
        protected int indicator = 0;

        public TestEnvironment()
        {
            indicator = 0;
            Console.WriteLine("ctor Test Environment");
        }
    }
}
