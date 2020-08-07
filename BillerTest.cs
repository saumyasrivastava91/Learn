using System;
using System.Collections.Generic;
using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class BillerTest
    {
        //Scenario 1
        [TestMethod]
        public void ApplyPromoCode_SingleItem_NoDiscountReturned()
        {
            //Arrange
            Biller biller = new Biller();
            var totalCost = 0;
            var itemList = new List<Item>();
            for (int i = 0; i < 1; i++)
            {
                itemList.Add(new Item()
                {
                    MRP = 50,
                    ItemToSell = "A"
                });

                itemList.Add(new Item()
                {
                    MRP = 30,
                    ItemToSell = "B"
                });

                itemList.Add(new Item()
                {
                    MRP = 20,
                    ItemToSell = "C"
                });
            }

            //Act
            var amountAfterDiscount = biller.ApplyPromoCode(itemList);

            //Assert
            var expectedBill = 100;
            Assert.AreEqual(expectedBill, amountAfterDiscount);
        }

        //Scenario 1
        [TestMethod]
        public void ApplyPromoCode_MultipleAAndBItemsWithOneC_DicountProvided()
        {
            //Arrange
            Biller biller = new Biller();
            var totalCost = 0;
            var itemList = new List<Item>();
            for (int i = 0; i < 5; i++)
            {
                itemList.Add(new Item()
                {
                    MRP = 50,
                    ItemToSell = "A"
                });
            }
            for (int i = 0; i < 5; i++)
            {
                itemList.Add(new Item()
                {
                    MRP = 30,
                    ItemToSell = "B"
                });
            }
            for (int i = 0; i < 1; i++)
            {
                itemList.Add(new Item()
                {
                    MRP = 20,
                    ItemToSell = "C"
                });
            }

            //Act
            var amountAfterDiscount = biller.ApplyPromoCode(itemList);

            //Assert
            var expectedBill = 370;
            Assert.AreEqual(expectedBill, amountAfterDiscount);
        }

        //Scenario 1
        [TestMethod]
        public void ApplyPromoCode_AllItemsWithAndWithoutDiscount_DicountProvided()
        {
            //Arrange
            Biller biller = new Biller();
            var totalCost = 0;
            var itemList = new List<Item>();
            for (int i = 0; i < 3; i++)
            {
                itemList.Add(new Item()
                {
                    MRP = 50,
                    ItemToSell = "A"
                });
            }
            for (int i = 0; i < 5; i++)
            {
                itemList.Add(new Item()
                {
                    MRP = 30,
                    ItemToSell = "B"
                });
            }
            for (int i = 0; i < 1; i++)
            {
                itemList.Add(new Item()
                {
                    MRP = 20,
                    ItemToSell = "C"
                });
            }
            for (int i = 0; i < 1; i++)
            {
                itemList.Add(new Item()
                {
                    MRP = 15,
                    ItemToSell = "D"
                });
            }

            //Act
            var amountAfterDiscount = biller.ApplyPromoCode(itemList);

            //Assert
            var expectedBill = 280;
            Assert.AreEqual(expectedBill, amountAfterDiscount);
        }
    }
}
