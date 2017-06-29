using Microsoft.VisualStudio.TestTools.UnitTesting;
using ListImplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListImplementation.Tests
{
    [TestClass()]
    public class SinglyListTests
    {
        [TestMethod()]
        public void AddTest()
        {
            SinglyList<String> testList = new SinglyList<string>();
            testList.Add("aaaa");
        }
    }
}