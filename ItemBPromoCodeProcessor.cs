namespace ClassLibrary1
{
    /// <summary>
    /// Class to hold logic for promotion of item "B".
    /// </summary>
    public class ItemBPromoCodeProcessor : BasePromoCodeProcessor, IPromoCodeProcessor
    {
        /// <summary>
        /// Item Purchased.
        /// </summary>
        protected override string ItemToProcess { get; set; } = "B";

        /// <summary>
        /// Minimum number of item that needs to be purchased to get bulk item discount.
        /// </summary>
        protected override int MinItemToPurchase { get; set; } = 2;

        /// <summary>
        /// Price at which the bulk item can be purchased.
        /// </summary>
        protected override int GroupedDiscountedPrice { get; set; } = 45;
    }
}
