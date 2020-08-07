using System.Collections.Generic;

namespace ClassLibrary1
{
    /// <summary>
    /// Class to hold logic for promotion of item "C".
    /// </summary>
    public class Biller
    {
        public int ApplyPromoCode(List<Item> items)
        {
            int totalCost = 0;

            foreach (var item in items)
            {
                totalCost += item.MRP;
            }

            IPromoCodeProvider promoCodeProvider = new PromoCodeProvider();
            IPromoCodeEngine promoCodeHelper = new PromoCodeEngine(promoCodeProvider);


            promoCodeHelper.RunPromotions(items, ref totalCost);

            return totalCost;
        }
    }
}
