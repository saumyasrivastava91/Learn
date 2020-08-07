using System.Collections.Generic;

namespace ClassLibrary1
{
    /// <summary>
    /// Promo code engine to run the promotions.
    /// </summary>
    public interface IPromoCodeEngine
    {
        /// <summary>
        /// Method to run promotions on the purchased items.
        /// </summary>
        /// <param name="items">item purchased</param>
        /// <param name="totalCost">total cost</param>
        void RunPromotions(List<Item> items, ref int totalCost);
    }
}
