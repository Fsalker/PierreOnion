using Microsoft.AspNetCore.Mvc;
using API.Models;
using System.Collections.Generic;

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class RecipeController : Controller
    {
        private static IRepo RecipeRepo { get; set; }

        public RecipeController(IRepo recipeRepo)
        {
            RecipeRepo = recipeRepo;
        }

        /*public String Test(int nr)
        {
            return "Hello, your number = "+nr;
        }*/
        
        [HttpGet]
        public List<Recipe> GetAll()
        {
            return RecipeRepo.ReadAll();
        }

        [HttpGet("{id}")]
        public Recipe GetRecipe(int id)
        {
            return RecipeRepo.Read(id);
        }

        [HttpPost("{asd}")]
        public string PostRecipe(string asd)
        {
            //RecipeRepo.Create(RecipeRepo.Read(0));
            return "Hello, "+asd;
        }
    }
}
