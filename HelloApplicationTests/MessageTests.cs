using NUnit.Framework;
using System;
using Assert = NUnit.Framework.Assert;

namespace HelloApplication.Tests
{
    [TestFixture]
    public class MessageTests
    {
        [TestCase()]
        public void DisplayTest_WhenMessageNull()
        {
            Message msg = new Message(null);
            Assert.Throws<Exception>(() => msg.Display());
        }


        [TestCase]
        public void DisplayTest_WhenMessageNotNull()
        {
            Message msg = new Message("hi");
            Assert.AreEqual("hi", msg.Display());
        }

        [TestCase]
        public void DisplayTest_WhenMessageNotNull1()
        {
            Message msg = new Message("hi");
            Assert.AreEqual("hi", msg.Display());
        }


    }
}