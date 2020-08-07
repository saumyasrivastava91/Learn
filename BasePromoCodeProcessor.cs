using System.Collections.Generic;
using System.Linq;

namespace ClassLibrary1
{
    public class BasePromoCodeProcessor
    {
        /// <summary>
        /// Price at which the bulk item can be purchased.
        /// </summary>
        protected virtual int GroupedDiscountedPrice { get; set; } = 0;

        /// <summary>
        /// Minimum number of item that needs to be purchased to get bulk item discount.
        /// </summary>
        protected virtual int MinItemToPurchase { get; set; } = 0;

        /// <summary>
        /// Item Purchased.
        /// </summary>
        protected virtual string ItemToProcess { get; set; } = null;

        /// <summary>
        /// Method to process promotion code.
        /// </summary>
        /// <param name="itemsPurchased"></param>
        /// <param name="totalCost"></param>
        public void ProcessPromotionCode(List<Item> itemsPurchased, ref int totalCost)
        {
            //Item on which promo has to be applied.
            var items = itemsPurchased.Where(x => x.ItemToSell.Equals(ItemToProcess));

            //Number of items purchased
            var numberOfItems = items?.Count();

            //MRP of item
            var mrp = items?.First().MRP;

            if (numberOfItems >= MinItemToPurchase && numberOfItems != 0)
            {
                var countLesserThanMinItemToPurchase = numberOfItems % MinItemToPurchase;
                var setOfMinItemToPurchaseCount = numberOfItems / MinItemToPurchase;

                //reduce the total cost of individual item as grouped discount has to be applied on it.
                totalCost -= (mrp * (numberOfItems ?? 0)) ?? 0;

                //Apply grouped discount. After dividing it into groups if any item exist then multiply by its MRP and add to total.
                totalCost += setOfMinItemToPurchaseCount * GroupedDiscountedPrice + (countLesserThanMinItemToPurchase * mrp) ?? 0;
            }
        }
    }
}
