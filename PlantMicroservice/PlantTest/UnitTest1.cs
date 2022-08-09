using System;
using Xunit;
using Moq;
using System.Collections.Generic;
using PlantMicroservice.Models;
using NUnit.Framework;
using System.Threading.Tasks;
using PlantMicroservice.Repository;

namespace PlantTest
{
    public class UnitTest1
    {
        List<PlantReorderDetails> dtls;
        Part pts;
        [SetUp]
        public void Setup()
        {
            dtls = new List<PlantReorderDetails>();
            {
                new PlantReorderDetails()
                {
                    PlantReorderId = 501,
                    PartId = 1,
                    PartDetails = "Cement",
                    ReorderStatus = "Requested",
                    ReorderDate = Convert.ToDateTime("2022 - 02 - 04")
                };
            }

            pts = new Part();
            {
                new Part()
                {
                    PartId = 1,
                    PartDescription = "Cement",
                    PartSpecification = "best quality",
                    StockInHand = 47

                };
            }
        }

        [Test]
        public async Task ViewPartsReOrder_GetsPartDetails()
        {
            Mock<IPlantRepo> mock = new Mock<IPlantRepo>();

            mock.Setup(p => p.ViewPartsReOrder()).ReturnsAsync(dtls);
            List<PlantReorderDetails> a = await mock.Object.ViewPartsReOrder();
            Assert.AreEqual(a.Count, dtls.Count);
        }

    }
}
