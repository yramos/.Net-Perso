using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class TestFizzBuzz
    {
        private FizzBuzz _monFizzBuzz = new FizzBuzz();

        [TestMethod]
        public void TestFizzBuzz_peutObtenirLesCentPremiersNombres()
        {
            List<String> listeDesCentsPremiersFizzBuzz = _monFizzBuzz.listeDesCentsPremiersFizzBuzz();

            Assert.IsNotNull(listeDesCentsPremiersFizzBuzz);
            Assert.AreEqual(100, listeDesCentsPremiersFizzBuzz.Count);
        }

        [TestMethod]
        public void TestFizzBuzz_troisRetourneFizz()
        { 
            List<String> listeDesCentsPremiersFizzBuzz = _monFizzBuzz.listeDesCentsPremiersFizzBuzz();

            Assert.AreEqual("Fizz", listeDesCentsPremiersFizzBuzz[2]);//l'indice commence à 0
        }

        [TestMethod]
        public void TestFizzBuzz_cinqRetourneBuzz() 
        {
            List<string> listeDesCentsPremiersFizzBuzz = _monFizzBuzz.listeDesCentsPremiersFizzBuzz();

            Assert.AreEqual("Buzz", listeDesCentsPremiersFizzBuzz[4]);
        }

        [TestMethod]
        public void TestFizzBuzz_nombreDivisibleParTroisRetourneFizz() 
        {
            List<string> listeDesCentsPremiersFizzBuzz = _monFizzBuzz.listeDesCentsPremiersFizzBuzz();

            Assert.AreEqual("Fizz", listeDesCentsPremiersFizzBuzz[5]);
            Assert.AreEqual("Fizz", listeDesCentsPremiersFizzBuzz[11]);
            Assert.AreEqual("Fizz", listeDesCentsPremiersFizzBuzz[17]);
        }
    }
}
