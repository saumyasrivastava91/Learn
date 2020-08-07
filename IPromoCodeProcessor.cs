using System.Collections.Generic;

namespace ClassLibrary1
{
    /// <summary>
    /// Interface of Promo Code Processor
    /// </summary>
    public interface IPromoCodeProcessor
    {
        /// <summary>
        /// Method to process promotion code.
        /// </summary>
        /// <param name="itemsPurchased"></param>
        /// <param name="totalCost"></param>
        void ProcessPromotionCode(List<Item> itemsPurchased, ref int totalCost);
    }
}
