using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

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
            customizations.AddRange(new List<Customization> {
               new Customization
               {
                   Price = 0,
                   Name = "Cherry Wood",
                   Id = 1
               },
               new Customization
               {
                   Price = 0,
                   Name = "Walnut Wood",
                   Id = 2
               },
                 new Customization
                {
                    Price = 0,
                    Name = "Maple Wood",
                    Id = 3
                },
               new Customization
               {
                   Price = 0,
                   Name = "Ambrosia Maple Wood",
                   Id = 4
               },
                new Customization
                {
                    Price = 0,
                    Name = "Oak Wood",
                    Id = 5
                },
                 new Customization
                 {
                     Price = 0,
                     Name = "Purple Heart Accent",
                     Id = 6
                 },
                 new Customization
                 {
                     Price = 0,
                     Name = "Make Similar to Portfolio Photo",
                     Id = 7
                 }}
               );

            return customizations;
        }
    }
}
