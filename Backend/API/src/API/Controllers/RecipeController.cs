using Microsoft.AspNetCore.Mvc;
using API.Models;
using System.Collections.Generic;

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class RecipeController : Controller
    {
        public IRepo ArrRecipe { get; set; }

        public RecipeController(IRepo arrRecipe)
        {
            ArrRecipe = arrRecipe;
        }

        [HttpGet]
        public List<Recipe> GetAllRecipes()
        {
            return ArrRecipe.ReadAllRecipes();
        }

        [HttpGet("{id}")]
        public Recipe GetRecipeById(int id)
        {
            return ArrRecipe.ReadRecipeById(id);
        }
    }
}
