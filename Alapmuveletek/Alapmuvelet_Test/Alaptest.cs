using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Alapmuveletek;

namespace Alapmuvelet_Test
{
    [TestClass]
    public class Alaptest
    {
        [TestMethod]
        public void TestOsszeadas()
        {
            //AAA - Arrange, Act, Assert
            //Arrange - példányosítás, előkészületek
            //Act - valamilyen művelet elvégzése 
            //Assert - a művelet eredményének összehasonlítása
            // valamilyen elvárt értékkel
            //Arrange
            Alapmuvelet alapmuvelet = new Alapmuvelet();

            //Act
            var sut = alapmuvelet.Osszeadas(10, 20);

            //Assert
            Assert.AreEqual(30, sut);
            
        }

        [TestMethod]
        public void TestKivonas()
        {
            Alapmuvelet alapmuvelet = new Alapmuvelet();
            var sut = alapmuvelet.Kivonas(30, 10);
            Assert.IsNotNull(alapmuvelet);
            Assert.IsNotNull(sut);
            Assert.AreEqual(20, sut);
            
        }

        [TestMethod]
        public void TestSzorzas()
        {
            Alapmuvelet alapmuvelet = new Alapmuvelet();
            var sut = alapmuvelet.Szorzas(5, 5);
            Assert.IsNotNull(alapmuvelet);
            Assert.IsNotNull(sut);
            Assert.AreEqual(25, sut);
        }

        [TestMethod]
        public void TestOsztas()
        {
            Alapmuvelet alapmuvelet = new Alapmuvelet();
            var sut = alapmuvelet.Osztas(10, 5);
            Assert.IsNotNull(alapmuvelet);
            Assert.IsNotNull(sut);
            Assert.AreEqual(2, sut);

        }
    }
}
