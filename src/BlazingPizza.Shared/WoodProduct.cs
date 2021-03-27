using System.Collections.Generic;
using System.Linq;

namespace BlazingPizza
{
    /// <summary>
    /// Represents a pre-configured template for a pizza a user can order
    /// </summary>
    public class WoodProduct
    {
        public int Id { get; set; }
        public const int DefaultLength = 12;
        public const int MinimumLength = 7;
        public const int MaximumLength = 18;

        public string Name { get; set; }

        public decimal BasePrice { get; set; }

        public int Length { get; set; }

        public string Description { get; set; }

        public string? LongDescription { get; set; }

        public string ImageUrl { get; set; }

        public List<Customization> Customizations { get; set; }

        public string GetFormattedBasePrice() => BasePrice.ToString("0.00");

        public decimal GetBasePrice()
        {
            decimal customSize = 0;// (Length - MinimumLength) * 5;
            return BasePrice + customSize;
        }

        public decimal GetTotalPrice()
        {
            decimal addOns = 0;
            if(Customizations != null)
            {
                // addOns = Customizations.Sum(t => t.Price);
            }
            return GetBasePrice() + addOns;
        }

        public string GetFormattedTotalPrice()
        {
            return GetTotalPrice().ToString("0.00");
        }
    }
}
