using NUnit.Framework;
//add class library
using Calculation;
using Mathoperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    /*[TestFixture]
    public class Calaculation_Tests
    {
    //in math operation class

        //for setup annotations put in top
        private Calculation? calculation;
        [SetUp] 
        public void SetUp() 
        {
            calculation = new Calculation(100, 100);
            Console.WriteLine("Setup");
        }

        //by using test report we are using the Testcae, so that report will contain all details 
        [TestCase(10,20,Author ="name_of_the_author",Description ="Testing_Addmeathod")]
        //[Test]
        [Order(3)]
        public void Add_Tests(int num1,int num2)
        {
            Console.WriteLine("Add order check");
            calculation = new Calculation(num1, num2);
            int res = calculation.Add();
            Assert.AreEqual(num1+num2,res);
        }


        //by avoiding test
        //option 1: comment [test]
        [Test]
        //option 2: 
        [Ignore("in progress",Until ="2023-07-12")]
        [Order(2)]
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
    }*/
    [TestFixture]
    public class Calaculation_Tests
    {
        //now we add reference the class library using add-> addreferences-> select the class then click ok.


        //for setup annotations put in top
        private CalaculationClass? calculation;
        [SetUp]
        public void SetUp()
        {
            calculation = new CalaculationClass(100, 100);
            Console.WriteLine("Setup");
        }

        //by using test report we are using the Testcae, so that report will contain all details 
        [TestCase(10, 20, Author = "name_of_the_author", Description = "Testing_Addmeathod")]
        //[Test]
        [Order(3)]
        public void Add_Tests(int num1, int num2)
        {
            Console.WriteLine("Add order check");
            calculation = new CalaculationClass(num1, num2);
            int res = calculation.Add();
            Assert.AreEqual(num1 + num2, res);
        }


        //by avoiding test
        //option 1: comment [test]
        [Test]
        //option 2: 
        [Ignore("in progress", Until = "2023-07-12")]
        [Order(2)]
        public void Sub_tests()
        {
            Console.WriteLine("sub order check");

            CalaculationClass calculation = new(40, 30);
            int res = calculation.Sub();
            Assert.AreEqual(10, res);
        }

        [Test]
        [Order(1)]
        public void Mul_tests()
        {
            Console.WriteLine("mult order check");

            CalaculationClass calculation = new(40, 30);
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
