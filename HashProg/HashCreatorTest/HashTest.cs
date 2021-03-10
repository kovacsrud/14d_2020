using NUnit.Framework;
using HashCreate;

namespace HashCreatorTest
{
    public class HashTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("22e67b691bcc1bb1c806364fb660294e","Valami szöveg")]
        [TestCase("3c10c2eabdbda72710357ba04f8a2941", @"g:\toyota.jpg")]
        public void HashTestMD5(string elvart,string szoveg)
        {
            HashCreator hashmd5 = new HashCreator();

            var sut = hashmd5.CreateHash(HashType.MD5, szoveg);

            Assert.AreEqual(elvart, sut);
        }


        
        [Test]
        [TestCase("E12C169414ED5747B42C02ACC432E409AD684162", "Valami szöveg")]
        [TestCase("81B71216BEA6BDA6789A11099CAAE0DEA72AC109", @"g:\toyota.jpg")]
        public void HashTestSHA1(string elvart,string szoveg)
        {
            HashCreator hashsha1 = new HashCreator();
            var sut = hashsha1.CreateHash(HashType.SHA1,szoveg,true);
            Assert.AreEqual(elvart, sut);
        }


        [Test]
        [TestCase("8EB0986CF9E36302DB4B9EB417D388D1EFD398A49C0AA3C70CF285756C84C7D2", "Valami szöveg")]
        [TestCase("0E0F12D0C5FFE23CB10E10E3661F7DB895E3B505DF18ED3AD823DA4F63014A87", @"g:\toyota.jpg")]
        public void HashTestSHA256(string elvart, string szoveg)
        {
            HashCreator hashsha256 = new HashCreator();
            var sut = hashsha256.CreateHash(HashType.SHA256, szoveg, true);
            Assert.AreEqual(elvart, sut);
        }
    }
}