using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists.Tests
{
    [TestClass()]
    public class ListTests
    {
        [TestMethod()]
        public void SingleLinkTest()
        {
            var list = new SingleLinkList();
            Assert.IsNull(list.Find("Fred"));
            list.Add("Fred");
            Assert.AreEqual("Fred", list.Find("Fred").Value);
            Assert.IsNull(list.Find("Wilma"));
            Assert.AreEqual("Fred", list.Find("Fred").Value);
            list.Add("Wilma");
            Assert.AreEqual("Wilma", list.Find("Wilma").Value);
            var ans = new string[]{"Fred", "Wilma"};
            CollectionAssert.AreEqual(ans, list.Values());

            list = new SingleLinkList();
            list.Add("Fred");
            list.Add("Wilma");
            list.Add("Betty");
            list.Add("Barney");
            ans = new string[] { "Fred", "Wilma","Betty","Barney" };
            CollectionAssert.AreEqual(ans,list.Values());
            list.Delete(list.Find("Wilma").Value);
            ans = new string[] { "Fred", "Betty","Barney" };

            CollectionAssert.AreEqual(ans, list.Values());
            list.Delete(list.Find("Barney").Value);
            ans = new string[]{"Fred", "Betty"};
            CollectionAssert.AreEqual(ans, list.Values());
            list.Delete(list.Find("Fred").Value);
            ans = new string[]{"Betty"};
            CollectionAssert.AreEqual(ans, list.Values());
            list.Delete(list.Find("Betty").Value);
            ans = new string[]{};
            CollectionAssert.AreEqual(ans, list.Values());

        }

        [TestMethod()]
        public void DoubleLinkTest()
        {
            var list = new DoubleLinkList();
            Assert.IsNull(list.Find("Fred"));
            list.Add("Fred");
            Assert.AreEqual("Fred", list.Find("Fred").Value);
            Assert.IsNull(list.Find("Wilma"));
            Assert.AreEqual("Fred", list.Find("Fred").Value);
            list.Add("Wilma");
            Assert.AreEqual("Wilma", list.Find("Wilma").Value);
            var ans = new string[] { "Fred", "Wilma" };
            CollectionAssert.AreEqual(ans, list.Values());

            list = new DoubleLinkList();
            list.Add("Fred");
            list.Add("Wilma");
            list.Add("Betty");
            list.Add("Barney");
            ans = new string[] { "Fred", "Wilma", "Betty", "Barney" };
            CollectionAssert.AreEqual(ans, list.Values());
            list.Delete(list.Find("Wilma").Value);
            ans = new string[] { "Fred", "Betty", "Barney" };

            CollectionAssert.AreEqual(ans, list.Values());
            list.Delete(list.Find("Barney").Value);
            ans = new string[] { "Fred", "Betty" };
            CollectionAssert.AreEqual(ans, list.Values());
            list.Delete(list.Find("Fred").Value);
            ans = new string[] { "Betty" };
            CollectionAssert.AreEqual(ans, list.Values());
            list.Delete(list.Find("Betty").Value);
            ans = new string[] { };
            CollectionAssert.AreEqual(ans, list.Values());

        }

        [TestMethod()]
        public void ArrayListTest()
        {
            var list = new MyArrayList(2);
            Assert.IsNull(list.Find("Fred"));
            list.Add("Fred");
            
            Assert.AreEqual("Fred", list.Find("Fred"));
            Assert.IsNull(list.Find("Wilma"));
            Assert.AreEqual("Fred", list.Find("Fred"));
            list.Add("Wilma");
            Assert.AreEqual("Wilma", list.Find("Wilma"));
            var ans = new string[] { "Fred", "Wilma" };
            CollectionAssert.AreEqual(ans, list.Values());

            list = new MyArrayList(2);
            list.Add("Fred");
            list.Add("Wilma");
            list.Add("Betty");
            list.Add("Barney");
            ans = new string[] { "Fred", "Wilma", "Betty", "Barney" };
            CollectionAssert.AreEqual(ans, list.Values());
            list.Delete(list.Find("Wilma"));
            ans = new string[] { "Fred", "Betty", "Barney" };

            CollectionAssert.AreEqual(ans, list.Values());
            list.Delete(list.Find("Barney"));
            ans = new string[] { "Fred", "Betty" };
            CollectionAssert.AreEqual(ans, list.Values());
            list.Delete(list.Find("Fred"));
            ans = new string[] { "Betty" };
            CollectionAssert.AreEqual(ans, list.Values());
            list.Delete(list.Find("Betty"));
            ans = new string[] { };
            CollectionAssert.AreEqual(ans, list.Values());

        }
    }
}