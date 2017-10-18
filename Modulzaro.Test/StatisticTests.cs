using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Modulzaro.Test
{
    [TestClass]
    public class StatisticTests
    {
        [TestMethod]
        public void NumberOfPatientsIs0()
        {
            var sum = Statistics.NumberOfPatient(new Patient[0]);
            Assert.AreEqual(0, sum);
        }

        [TestMethod]
        public void NumberOfPatientsIs1()
        {
            var sum = Statistics.NumberOfPatient(new Patient[]
                {
                    new Patient{}
                });
            Assert.AreEqual(1, sum);
        }

        [TestMethod]
        public void NumberOfPatientsIs5()
        {
            var sum = Statistics.NumberOfPatient(new Patient[]
                {
                    new Patient{},
                    new Patient{},
                    new Patient{},
                    new Patient{},
                    new Patient{}
                });
            Assert.AreEqual(5, sum);
        }

    }
}
