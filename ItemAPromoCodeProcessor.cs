namespace ClassLibrary1
{
    /// <summary>
    /// Class to hold logic for promotion of item "A".
    /// </summary>
    public class ItemAPromoCodeProcessor : BasePromoCodeProcessor, IPromoCodeProcessor
    {
        /// <summary>
        /// Item Purchased.
        /// </summary>
        protected override string ItemToProcess { get; set; } = "A";

        /// <summary>
        /// Minimum number of item that needs to be purchased to get bulk item discount.
        /// </summary>
        protected override int MinItemToPurchase { get; set; } = 3;

        /// <summary>
        /// Price at which the bulk item can be purchased.
        /// </summary>
        protected override int GroupedDiscountedPrice { get; set; } = 130;
    }
}
