using NUnit.Framework;
using Mathoperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestFixture]
    public class Calaculation_Tests
    {

        //for setup annotations put in top
        private Calculation? calculation;
        [SetUp] 
        public void SetUp() 
        {
            calculation = new Calculation(100, 100);
            Console.WriteLine("Setup");
        }


        [Test]
        [Order(2)]
        public void Add_Tests()
        {
            Console.WriteLine("Add order check");

            Calculation calculation = new Calculation(100,100);
            int res = calculation.Add();
            Assert.AreEqual(200,res);
        }

        [Test]
        [Order(3)]
        public void Sub_tests()
        {
            Console.WriteLine("sub order check");

            Calculation calculation = new(40, 30);
            int res = calculation.Sub();
            Assert.AreEqual(10,res);
        }

        [Test]
        [Order(1)]
        public void Mul_tests()
        {
            Console.WriteLine("mult order check");

            Calculation calculation = new(40, 30);
            int res = calculation.Mul();
            Assert.AreEqual(1200, res);
        }

        //for teardown annotations in down of the all tests are completed
        [TearDown]
        public void Closetest()
        {
            Console.WriteLine("teardown");
            calculation = null;
        }
    }
}
