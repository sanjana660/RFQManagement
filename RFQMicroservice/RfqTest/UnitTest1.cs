using NUnit.Framework;
using Moq;
using RFQManagement;
using RFQManagement.Repository;
using System.Collections.Generic;
using RFQManagement.Models;
using System;
using System.Threading.Tasks;

namespace RfqTest
{
    public class Tests
    {
        List<Rfq> rfqvar;
        [SetUp]
        public void Setup()
        {
            rfqvar = new List<Rfq>();
            {
                new Rfq()
                {
                    rfqId = 1,
                    demandid = 10,
                    Part_Id = 2,
                    partName = "Plow",
                    Quantity = "12",
                    timetoSupply = Convert.ToDateTime("12-04-2022"),
                    Specification = "abcde"
                };
            }
        }

        [TestCase(2)]
        public async Task Get_RfqDetail(int Part_Id)
        {
            Mock<IrfqRepo> mock = new Mock<IrfqRepo>();
            mock.Setup(p => p.Get(Part_Id)).ReturnsAsync(rfqvar);
            List<Rfq> a = await mock.Object.Get(Part_Id);
            Assert.IsNotNull(a);
        }
    }
}