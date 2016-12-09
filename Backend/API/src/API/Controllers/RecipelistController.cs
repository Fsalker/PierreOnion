using Microsoft.AspNetCore.Mvc;
using API.Models;

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class RecipelistController : Controller
    {
        public IRepo ArrRecipe { get; set; }

        public RecipelistController(IRepo arrRecipe)
        {
            ArrRecipe = arrRecipe;
        }

        [HttpGet]
        public string getMethod()
        {
            return ArrRecipe.ReadAllRecipes();
        }
    }
}
