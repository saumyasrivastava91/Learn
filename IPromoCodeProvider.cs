using System.Collections.Generic;

namespace ClassLibrary1
{
    /// <summary>
    /// Interface of Promo code Provider
    /// </summary>
    public interface IPromoCodeProvider
    {
        /// <summary>
        /// Dictionary to hold key value pair of each item vs its promotion definition.
        /// </summary>
        Dictionary<string, IPromoCodeProcessor> ItemVsPromoCodeDictionary { get; }
    }
}
