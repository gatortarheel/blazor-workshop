using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazingPizza.Server
{
    [Route("portfolio")]
    [ApiController]
    public class PortfolioController : Controller
    {
        private readonly PizzaStoreContext _db;

        public PortfolioController(PizzaStoreContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<List<WoodProduct>>> GetPortfolio()
        {
            List<WoodProduct> portfolio = new List<WoodProduct>();

            WoodProduct servingTray = new WoodProduct
            {
                Id = 1,
                BasePrice = 150,
                Description = "Live Edge Serving Trays", 
                LongDescription = "Made of three primary pieces from five woods: walnut, cherry, oak, maple, and ambrosia maple.",//  Accent strips such as Purpleheart, Paduk can be added between each section.  Rope handles are added for easy carrying.",
                ImageUrl = "https://tarheelstorage2021.blob.core.windows.net/woodworking/servingtray-61.jpg",
                Name = "Live Edge Serving Tray",
            };

            servingTray.Customizations = new List<Customization>();
         
            portfolio.Add(servingTray);

            return portfolio;
            
            
            //return (await _db.Specials.ToListAsync()).OrderByDescending(s => s.BasePrice).ToList();
        }
    }
}
