using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloApplication.Tests
{
    [TestClass()]
    public class MessageTests
    {
        [TestMethod, ExpectedException(typeof(Exception))]
        public void DisplayTest_WhenMessageNull()
        {
            Message msg = new Message(null);
            msg.Display();
        }


        [TestMethod]
        public void DisplayTest_WhenMessageNotNull()
        {
            Message msg = new Message("hi");
            msg.Display();
        }
    }
}