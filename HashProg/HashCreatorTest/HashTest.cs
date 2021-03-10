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
    }
}