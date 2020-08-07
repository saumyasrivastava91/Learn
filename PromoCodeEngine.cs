using System.Collections.Generic;

namespace ClassLibrary1
{
    /// <summary>
    /// Promo code engine class to run promotions.
    /// </summary>
    public class PromoCodeEngine : IPromoCodeEngine
    {
        private readonly IPromoCodeProvider _promoCodeProvider;
        public PromoCodeEngine(IPromoCodeProvider promoCodeProvider)
        {
            _promoCodeProvider = promoCodeProvider;
        }

        /// <summary>
        /// Method to run promotions on the purchased items.
        /// </summary>
        /// <param name="items">item purchased</param>
        /// <param name="totalCost">total cost</param>
        public void RunPromotions(List<Item> items, ref int totalCost)
        {
            //Temporary cache to store the processed items.
            var processedItem = new List<string>();

            foreach (var item in items)
            {
                if (_promoCodeProvider.ItemVsPromoCodeDictionary.TryGetValue(item.ItemToSell, out var promoCodeProcessor))
                {
                    if (!processedItem.Contains(item.ItemToSell))
                    {
                        processedItem.Add(item.ItemToSell);

                        //Sending all items to process promo code.
                        promoCodeProcessor.ProcessPromotionCode(items, ref totalCost);
                    }
                }
            }
        }
    }
}
