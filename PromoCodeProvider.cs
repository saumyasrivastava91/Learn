using System.Collections.Generic;

namespace ClassLibrary1
{
    /// <summary>
    /// Class to hold the promo codes definitions.
    /// </summary>
    public class PromoCodeProvider : IPromoCodeProvider
    {
        /// <summary>
        /// Dictionary to hold key value pair of each item vs its promotion definition.
        /// </summary>
        public Dictionary<string, IPromoCodeProcessor> ItemVsPromoCodeDictionary =>
            new Dictionary<string, IPromoCodeProcessor>()
            {
                {"A", new ItemAPromoCodeProcessor()},
                {"B", new ItemBPromoCodeProcessor()},
                {"C", new ItemCPromoCodeProcessor()}
            };
    }
}
