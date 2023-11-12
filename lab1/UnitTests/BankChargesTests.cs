using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.UnitTests
{
    internal class BankChargesTests
    {
        private BankCharges _bankCharges { get; set; } = null;

        [SetUp]

        public void Setup()
        {
            _bankCharges = new BankCharges();
        }

        [Test, Apartment(System.Threading.ApartmentState.STA)] 
        public void setMonthlyFeeTest() 
        {

            _bankCharges.setMonthlyFee(100);

            Assert.AreEqual("20.00", _bankCharges.monthlyFee.Text);
        }

        [Test, Apartment(System.Threading.ApartmentState.STA)]
        public void createChequesTest()
        {
            _bankCharges.createCheques_Click(null, null);

           Assert.AreEqual("10.00", _bankCharges.monthlyFee.Text);
        }
    }
}
