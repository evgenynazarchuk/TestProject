using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using System;

namespace TestProject.MSTest.Sample
{
    [TestClass]
    public class Test1 : TestEnvironment
    {
        public Test1()
        {
            Console.WriteLine($"ctor Tests1 - {indicator}");
        }

        [TestInitialize]
        public void Init()
        {
            Console.WriteLine($"ctor Tests1 SetUp - {indicator}");
            //indicator = 0;
            //Console.WriteLine($"ctor Tests1 SetUp {indicator}");
        }

        [TestMethod]
        public void TestMethod1()
        {
            indicator++;
            //await Task.Delay(5000);
            Task.Delay(5000).GetAwaiter().GetResult();
            Console.WriteLine($"Test1 - {indicator}");
        }

        [TestMethod]
        public void TestMethod2()
        {
            indicator++;
            //await Task.Delay(5000);
            Task.Delay(5000).GetAwaiter().GetResult();
            Console.WriteLine($"Test2 - {indicator}");
        }

        [TestMethod]
        public void TestMethod3()
        {
            indicator++;
            //await Task.Delay(5000);
            Task.Delay(5000).GetAwaiter().GetResult();
            Console.WriteLine($"Test3 - {indicator}");
        }

        [TestMethod]
        public void TestMethod4()
        {
            indicator++;
            //await Task.Delay(5000);
            Task.Delay(5000).GetAwaiter().GetResult();
            Console.WriteLine($"Test4 - {indicator}");
        }

        [TestMethod]
        public void TestMethod5()
        {
            indicator++;
            //await Task.Delay(5000);
            Task.Delay(5000).GetAwaiter().GetResult();
            Console.WriteLine($"Test5 - {indicator}");
        }

        [TestMethod]
        public void TestMethod6()
        {
            indicator++;
            //await Task.Delay(5000);
            Task.Delay(5000).GetAwaiter().GetResult();
            Console.WriteLine($"Test6 - {indicator}");
        }

        [TestMethod]
        public void TestMethod7()
        {
            indicator++;
            //await Task.Delay(5000);
            Task.Delay(5000).GetAwaiter().GetResult();
            Console.WriteLine($"Test7 - {indicator}");
        }

        [TestMethod]
        public void TestMethod8()
        {
            indicator++;
            //await Task.Delay(5000);
            Task.Delay(5000).GetAwaiter().GetResult();
            Console.WriteLine($"Test8 - {indicator}");
        }

        [TestMethod]
        public void TestMethod9()
        {
            indicator++;
            //await Task.Delay(5000);
            Task.Delay(5000).GetAwaiter().GetResult();
            Console.WriteLine($"Test9 - {indicator}");
        }

        [TestMethod]
        public void TestMethod10()
        {
            indicator++;
            //await Task.Delay(5000);
            Task.Delay(5000).GetAwaiter().GetResult();
            Console.WriteLine($"Test10 - {indicator}");
        }

        [TestMethod]
        public void TestMethod11()
        {
            indicator++;
            //await Task.Delay(5000);
            Task.Delay(5000).GetAwaiter().GetResult();
            Console.WriteLine($"Test11 - {indicator}");
        }

        [TestMethod]
        public void TestMethod12()
        {
            indicator++;
            //await Task.Delay(5000);
            Task.Delay(5000).GetAwaiter().GetResult();
            Console.WriteLine($"Test12 - {indicator}");
        }

        [TestMethod]
        public void TestMethod13()
        {
            indicator++;
            //await Task.Delay(5000);
            Task.Delay(5000).GetAwaiter().GetResult();
            Console.WriteLine($"Test13 - {indicator}");
        }

        [TestMethod]
        public void TestMethod14()
        {
            indicator++;
            //await Task.Delay(5000);
            Task.Delay(5000).GetAwaiter().GetResult();
            Console.WriteLine($"Test14 - {indicator}");
        }

        [TestMethod]
        public void TestMethod15()
        {
            indicator++;
            //await Task.Delay(5000);
            Task.Delay(5000).GetAwaiter().GetResult();
            Console.WriteLine($"Test15 - {indicator}");
        }

        [TestMethod]
        public void TestMethod16()
        {
            indicator++;
            //await Task.Delay(5000);
            Task.Delay(5000).GetAwaiter().GetResult();
            Console.WriteLine($"Test16 - {indicator}");
        }

        [TestMethod]
        public void TestMethod17()
        {
            indicator++;
            //await Task.Delay(5000);
            Task.Delay(5000).GetAwaiter().GetResult();
            Console.WriteLine($"Test17 - {indicator}");
        }

        [TestMethod]
        public void TestMethod18()
        {
            indicator++;
            //await Task.Delay(5000);
            Task.Delay(5000).GetAwaiter().GetResult();
            Console.WriteLine($"Test18 - {indicator}");
        }

        [TestMethod]
        public void TestMethod19()
        {
            indicator++;
            //await Task.Delay(5000);
            Task.Delay(5000).GetAwaiter().GetResult();
            Console.WriteLine($"Test9 - {indicator}");
        }

        [TestMethod]
        public void TestMethod20()
        {
            indicator++;
            //await Task.Delay(5000);
            Task.Delay(5000).GetAwaiter().GetResult();
            Console.WriteLine($"Test10 - {indicator}");
        }
    }
}
