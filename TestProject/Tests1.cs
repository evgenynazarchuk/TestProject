using System;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestProject
{
    [Parallelizable(ParallelScope.Self)]
    [TestFixture]
    public class Tests1 : TestEnvironment
    {
        public Tests1()
        {
            indicator = 0;
            Console.WriteLine("ctor Tests");
        }

        [SetUp]
        public void Init()
        {
            Console.WriteLine($"ctor Tests SetUp {indicator}");
            indicator = 0;
            Console.WriteLine($"ctor Tests SetUp {indicator}");
        }

        [Test]
        public async Task Test1()
        {
            indicator++;
            await Task.Delay(5000);
            Console.WriteLine($"Test1 - {indicator}");
            Assert.Pass();
        }

        [Test]
        public async Task Test2()
        {
            indicator++;
            await Task.Delay(5000);
            Console.WriteLine($"Test2 - {indicator}");
            Assert.Pass();
        }

        [Test]
        public async Task Test3()
        {
            indicator++;
            await Task.Delay(5000);
            Console.WriteLine($"Test3 - {indicator}");
            Assert.Pass();
        }
    }
}