using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExamples
{
    [TestClass]
    public class TestClass1
    {
        MyClass obj;

        [TestMethod]
        public void MyTest()
        {
            MyClass obj2 = obj;
            obj2.Foo();
        }
    }

    class MyClass
    {
        public void Foo()
        {
            Console.WriteLine("Foo");
        }
    }
}
