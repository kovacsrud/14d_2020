using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium;


namespace WpfOsztasTest
{
    public class Tests
    {
        protected const string WindowsApplicationDriverUrl = "http://127.0.0.1:4723";

        private const string WpfProgramId = @"G:\c#_uj_projektek\14d_2000\WpfAutoTest\WpfAutoTest\WpfAutoTest.exe";

        private const string WpfProgramPath = @"G:\c#_uj_projektek\14d_2000\WpfAutoTest\WpfAutoTest\";

        protected static WindowsDriver<WindowsElement> driver;

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}