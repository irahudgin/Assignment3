using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace lab1.UnitTests
{
    internal class ShippingTests
    {
        private ShippingCharges _shipping { get; set; } = null;

        [SetUp]
        public void Setup()
        {
            _shipping = new ShippingCharges();
        }

        [Test, Apartment(System.Threading.ApartmentState.STA)]
        public void shippingTest()
        {
            string weight = "5";
            string distance = "1200";
            double expected = 4.40;
            var results = _shipping.calculateShippingCost(weight, distance);

            Assert.AreEqual(results, expected);
        }
    }
}
