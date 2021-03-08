using NUnit.Framework;
using Alapmuveletek;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System;

namespace NUnitAlapmuveletTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(10,10,20)]
        [TestCase(10, 20, 30)]
        [TestCase(100, 100, 200)]
        [TestCase(35, 25, 60)]
        [TestCase(35.788,25.621,61.3)]
        public void TestOsszead(double a,double b,double elvart)
        {
            Alapmuvelet alapmuvelet = new Alapmuvelet();
            var sut = alapmuvelet.Osszeadas(a, b);
            Assert.AreEqual(elvart, sut,0.2);
        }


        [Test,TestCaseSource("GetTesztEsetek")]
        public void TestOsszead2(double a, double b, double elvart)
        {
            Alapmuvelet alapmuvelet = new Alapmuvelet();
            var sut = alapmuvelet.Osszeadas(a, b);
            Assert.AreEqual(elvart, sut, 0.2);
        }

        private static IEnumerable<double[]> GetTesztEsetek()
        {
            var sorok = File.ReadAllLines("osszeadas_tesztesetek.csv");

            for (int i = 0; i < sorok.Length; i++)
            {
                var e = sorok[i].Split(';');
                double a = Convert.ToDouble(e[0]);
                double b = Convert.ToDouble(e[1]);
                double elvart = Convert.ToDouble(e[2]);
                yield return new[] { a, b, elvart };

            }

        }

       

    }
}