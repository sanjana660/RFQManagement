using NUnit.Framework;
using Moq;
using PlantMicroservice.Models;
using PlantMicroservice.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace PlantTest
{
    public class Tests
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
                    PartDetails = "Plows",
                    ReorderStatus = "Requested",
                    ReorderDate = Convert.ToDateTime("2022 - 08 - 10")
                };
            }
            pts = new Part();
            {
                new Part()
                {
                    PartId = 1,
                    PartDescription = "Plows",
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
            Assert.That(dtls.Count, Is.EqualTo(a.Count));
        }

        [TestCase(1)]
        public async Task ViewStockInHand_GetsStock(int PartId)
        {
            Mock<IPlantRepo> mock = new Mock<IPlantRepo>();

            mock.Setup(p => p.ViewStockInHand(PartId)).ReturnsAsync(pts);
           

            Part a = await mock.Object.ViewStockInHand(PartId);
            Assert.IsNotNull(a);
        }

    }
}