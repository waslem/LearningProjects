using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace cstypes
{

    [TestClass]
    public class ReferenceTypesAndValueTypes
    {
        [TestMethod]
        public void IdentityTest()
        {
            Invoice firstInvoice = new Invoice();
            firstInvoice.ID = 1;
            firstInvoice.Description = "TEST";
            firstInvoice.Amount = 0.0M;

            Invoice secondInvoice = new Invoice();
            firstInvoice.ID = 1;
            firstInvoice.Description = "TEST";
            firstInvoice.Amount = 0.0M;

            Assert.IsFalse(object.ReferenceEquals(secondInvoice, firstInvoice));
            Assert.IsTrue(firstInvoice.ID == 1);

            secondInvoice.ID = 2;

            Assert.IsTrue(secondInvoice.ID == 2);

            Assert.IsTrue(firstInvoice.ID == 1);

            secondInvoice = firstInvoice;

            Assert.IsTrue(object.ReferenceEquals(secondInvoice, firstInvoice));

            secondInvoice.ID = 5;

            Assert.IsTrue(firstInvoice.ID == 5);
        }

        [TestMethod]
        public void ValueTypeTest()
        {
            int x = 5;
            int y = x;

            y = 10;

            Assert.IsTrue(x == 5);
            Assert.IsTrue(y == 10);
        }

        [TestMethod]
        public void PassByValue()
        {
            Invoice inv = new Invoice();
            inv.ID = 1;
            inv.Description = "TEST";
            int value = 1;

            DoWork(ref inv, ref value);

            Assert.IsTrue(inv.ID == 5);
            Assert.IsTrue(inv.Description == "TEST");
            Assert.IsTrue(value == 3);

        }

        void DoWork(ref Invoice inv, ref int value)
        {
            inv.ID = 5;
            value = 3;
        }

        [TestMethod]
        public void stringTests()
        {
            string name = " Jamie ";

            name = name.Trim();

            Assert.IsTrue(name.Equals("Jamie",comparisonType: StringComparison.CurrentCulture));
        }
    }
}
