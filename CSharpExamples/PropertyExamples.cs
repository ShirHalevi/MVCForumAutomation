using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpExamples
{
    [TestClass]
    public class PropertyExamples
    {
        [TestMethod]
        public void WithMethods()
        {
            var myCar = new Car1();
            var yourCar = new Car1();
            myCar.SetFuel(100);
            yourCar.SetFuel(200);

            Assert.AreEqual(100, myCar.GetFuel());
            Assert.AreEqual(200, yourCar.GetFuel());
        }

        [TestMethod]
        public void WithField()
        {
            var myCar = new Car2();
            var yourCar = new Car2();
            myCar.Fuel = 100;
            yourCar.Fuel = 200;

            Assert.AreEqual(100, myCar.Fuel);
            Assert.AreEqual(200, yourCar.Fuel);
        }

        [TestMethod]
        public void WithSimpleProperty()
        {
            var myCar = new Car3();
            var yourCar = new Car3();
            myCar.Fuel = 100;
            yourCar.Fuel = 200;

            Assert.AreEqual(100, myCar.Fuel);
            Assert.AreEqual(200, yourCar.Fuel);
        }

        [TestMethod]
        public void WithAutoProperty()
        {
            var myCar = new Car4();
            var yourCar = new Car4();
            myCar.Fuel = 100;
            yourCar.Fuel = 200;

            Assert.AreEqual(100, myCar.Fuel);
            Assert.AreEqual(200, yourCar.Fuel);
        }

    }

    public class Car4
    {
        public double Fuel { get; set; }
    }

    public class Car3
    {
        private double _fuel = 0;

        // Property:
        public double Fuel
        {
            get
            {
                Console.WriteLine("Reading value of Fuel");
                return _fuel;
            }
            set
            {
                Console.WriteLine("Fuel was changed from " + _fuel + " to " + value);
                _fuel = value;
            }
        }
    }

    public class Car2
    {
        public double Fuel;
    }
    
    public class Car1
    {
        private double _fuel = 0;

        public double GetFuel()
        {
            return _fuel;
        }

        public void SetFuel(double value)
        {
            Console.WriteLine("Fuel was changed from " + _fuel + " to " + value);
            _fuel = value;
        }
    }
}
