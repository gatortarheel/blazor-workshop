using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazingPizza.Server
{
    [Route("customizations")]
    [ApiController]
    public class CustomizationsController : Controller
    {
        private readonly PizzaStoreContext _db;

        public CustomizationsController(PizzaStoreContext db)
        {
            _db = db;
        }

        /// <summary>
        /// could make this product specific 
        /// serving trays, cutting boards, etc.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<List<Customization>>> GetCustomizations()
        {
            List<Customization> customizations = new List<Customization>();

            Customization cherry = new Customization
            {
                Price = 0,
                Name = "Cherry Wood",
                Id = 1
            };

            Customization walnut = new Customization
            {
                Price = 5,
                Name = "Add Walnut Wood",
                Id = 2
            };

            Customization PurpleHeart = new Customization
            {
                Price = 5,
                Name = "Add Purple Heart Featuress",
                Id = 3
            };

            Customization engraving = new Customization
            {
                Price = 5,
                Name = "Add Personalized Engraving",
                Id = 4
            };

            Customization ropeHandle = new Customization
            {
                Price = 5,
                Name = "Add Rope Handle",
                Id = 5
            };

            Customization similarToPortfolio = new Customization
            {
                Price = 0,
                Name = "Make Similar to Portfolio Photo",
                Id = 6
            };
            customizations.Add(cherry);
            customizations.Add(walnut);
            customizations.Add(PurpleHeart);
            customizations.Add(engraving);
            customizations.Add(ropeHandle);
            customizations.Add(similarToPortfolio);

            return customizations;

            //return await _db.Toppings.OrderBy(t => t.Name).ToListAsync();
        }
    }
}
