using NUnit.Framework;
using HashCreate;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;
using NUnit.Framework.Interfaces;

namespace HashCreatorTest
{
    public class HashTests
    {
        protected static ExtentReports extReport;
        protected static ExtentTest extTest;

        [SetUp]
        public void Setup()
        {
        }

        [OneTimeSetUp]
        public static void ReportSetup()
        {
            extReport = new ExtentReports();
            var htmlreporter = new ExtentHtmlReporter(@"g:\14d_extrep\");
            extReport.AddSystemInfo("Teszt","Hash dll tesztelése");
            extReport.AttachReporter(htmlreporter);
            htmlreporter.Config.DocumentTitle = "Hash funkciók tesztelése";
            htmlreporter.Config.ReportName = "Hash hibakeresés";
            htmlreporter.Config.Theme= Theme.Standard;
        }

        [Test]
        [TestCase("22e67b691bcc1bb1c806364fb660294e","Valami szöveg")]
        [TestCase("3c10c2eabdbda72710357ba04f8a2941", @"g:\toyota.jpg")]
        public void HashTestMD5(string elvart,string szoveg)
        {
            extTest = extReport.CreateTest("MD5 hash tesztelése");
            HashCreator hashmd5 = new HashCreator();

            var sut = hashmd5.CreateHash(HashType.MD5, szoveg);

            Assert.AreEqual(elvart, sut);
            extTest.Log(Status.Pass,"MD5 hash teszt rendben.");
        }


        
        [Test]
        [TestCase("E12C169414ED5747B42C02ACC432E409AD684162", "Valami szöve")]
        [TestCase("81B71216BEA6BDA6789A11099CAAE0DEA72AC109", @"g:\toyota.jpg")]
        public void HashTestSHA1(string elvart,string szoveg)
        {
            extTest = extReport.CreateTest("SHA1 teszt");
            HashCreator hashsha1 = new HashCreator();
            var sut = hashsha1.CreateHash(HashType.SHA1,szoveg,true);
            Assert.AreEqual(elvart, sut);
            extTest.Log(Status.Pass,"SHA1 teszt rendben");
        }


        [Test]
        [TestCase("8EB0986CF9E36302DB4B9EB417D388D1EFD398A49C0AA3C70CF285756C84C7D2", "Valami szöve")]
        [TestCase("0E0F12D0C5FFE23CB10E10E3661F7DB895E3B505DF18ED3AD823DA4F63014A87", @"g:\toyota.jpg")]
        public void HashTestSHA256(string elvart, string szoveg)
        {
            extTest = extReport.CreateTest("SHA256 teszt");
            HashCreator hashsha256 = new HashCreator();
            var sut = hashsha256.CreateHash(HashType.SHA256, szoveg, true);
            Assert.AreEqual(elvart, sut);
            extTest.Log(Status.Pass,"SHA256 teszt rendben");
        }

        [TearDown]

        public static void CloseReport()
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stacktrace = TestContext.CurrentContext.Result.StackTrace;
            var errormsg = TestContext.CurrentContext.Result.Message;

            if (status==TestStatus.Failed)
            {
                //extTest.Log(Status.Fail,stacktrace+";"+errormsg);
                extTest.Log(Status.Fail, stacktrace);
                extTest.Log(Status.Fail,errormsg);
            }

        }

        [OneTimeTearDown]
        public static void EndTest()
        {
            extReport.Flush();
        }
    }
}