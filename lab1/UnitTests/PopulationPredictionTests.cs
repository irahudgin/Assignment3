using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace lab1.UnitTests
{
    internal class PopulationPredictionTests
    {
        private PopulationPrediction _prediction { get; set; } = null;

        [SetUp]
        public void Setup()
        {
            _prediction = new PopulationPrediction();
        }

        [Test, Apartment(System.Threading.ApartmentState.STA)]
        public void populationGrowthTest()
        {
            var results = _prediction.populationGrowth(10, 30.00, 5);
            Assert.AreEqual(33, results);
            
        }
    }
}
