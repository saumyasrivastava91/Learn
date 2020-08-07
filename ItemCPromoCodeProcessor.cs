using System.Collections.Generic;
using System.Linq;

namespace ClassLibrary1
{
    /// <summary>
    /// Class to hold logic for promotion of item "C".
    /// </summary>
    public class ItemCPromoCodeProcessor : IPromoCodeProcessor
    {
        /// <summary>
        /// Price at which the bulk item can be purchased.
        /// </summary>
        private const int GroupedDiscount = 30;

        /// <summary>
        /// Item Purchased.
        /// </summary>
        public string ItemToProcess => "C";

        /// <summary>
        /// Method to process promotion code.
        /// </summary>
        /// <param name="itemsPurchased"></param>
        /// <param name="totalCost"></param>
        public void ProcessPromotionCode(List<Item> itemsPurchased, ref int totalCost)
        {
            var items = itemsPurchased.Where(x => x.ItemToSell.Equals(ItemToProcess));

            var count = items.Count();
            var mrp = items.First().MRP;
            int mrpOfD = 0;

            var countOfD = itemsPurchased.Count(x => x.ItemToSell.Equals("D"));
            if (countOfD != 0)
            {
                mrpOfD = itemsPurchased.First(x => x.ItemToSell.Equals("D")).MRP;
            }
            if (itemsPurchased.Count(x => x.ItemToSell.Equals("D")) == count)
            {
                totalCost -= (mrp * count);

                totalCost -= (mrpOfD * countOfD);

                totalCost += countOfD * GroupedDiscount;
            }
        }
    }
}
