using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace API.Models
{
    public class Repo : IRepo
    {
        public List<Recipe> ArrRecipe = new List<Recipe>();

        public Repo()
        {
            Ingredient ingredient1 = new Ingredient(0, "Lapte", 500, "ml");
            Ingredient ingredient2 = new Ingredient(1, "Oua", 2, "buc");

            List<Ingredient> ingredients = new List<Ingredient>();
            ingredients.Add(ingredient1);
            ingredients.Add(ingredient2);

            DateTime date1 = new DateTime(2016, 11, 15);
            Comment comment1 = new Comment(0, "Gigy", "Chea mai marf' retzetă smrfm", 4.5f, date1, 0);
            DateTime date2 = new DateTime(2016, 10, 24);
            Comment comment2 = new Comment(1, "Johnutz", "Retzetah Khitroas'", 2.0f, date2, 0);
            DateTime date3 = new DateTime(1914, 7, 28);
            Comment comment3 = new Comment(2, "Dolfy", "Bomba retzetush - a incep00t PRM'", 4.7f, date3, 1);
            DateTime date4 = new DateTime(1918, 11, 11);
            Comment comment4 = new Comment(3, "Hitly", "Nash pa", 1.5f, date4, 1);
            DateTime date5 = new DateTime(2016, 6, 5);
            Comment comment5 = new Comment(4, "Danutz", "Cea mai valoroasa", 4.3f, date5, 1);

            List<Comment> comments = new List<Comment>();
            comments.Add(comment1);
            comments.Add(comment2);
            comments.Add(comment3);
            comments.Add(comment4);
            comments.Add(comment5);

            Recipe recipe1 = new Recipe(0, "Gogosi bomba", "http://www.click.ro/sites/default/files/styles/articol/public/medias/2016/02/09/gogosi-cu-crema-de-vanilie-si-ciocolata-580x400.jpg?itok=6CsQizOI",
                "Introduceti bomba in gogoasa si obtineti gogoasa bomba", 4.2f, 5f, ingredients, comments, 47, 3);
            Recipe recipe2 = new Recipe(1, "Bomba gogoasa", "http://www.click.ro/sites/default/files/styles/articol/public/medias/2016/02/09/gogosi-cu-crema-de-vanilie-si-ciocolata-580x400.jpg?itok=6CsQizOI",
                "Introduceti bomba in gogoasa si obtineti gogoasa bomba", 4.2f, 5f, ingredients, comments, 47, 3);
            Recipe recipe3 = new Recipe(2, "Ogosi bombag", "http://www.click.ro/sites/default/files/styles/articol/public/medias/2016/02/09/gogosi-cu-crema-de-vanilie-si-ciocolata-580x400.jpg?itok=6CsQizOI",
                "Introduceti bomba in gogoasa si obtineti gogoasa bomba", 4.2f, 5f, ingredients, comments, 47, 3);
            Recipe recipe4 = new Recipe(3, "Mai multe gogosi", "http://www.click.ro/sites/default/files/styles/articol/public/medias/2016/02/09/gogosi-cu-crema-de-vanilie-si-ciocolata-580x400.jpg?itok=6CsQizOI",
                "Introduceti bomba in gogoasa si obtineti gogoasa bomba", 4.2f, 5f, ingredients, comments, 47, 3);

            ArrRecipe.Add(recipe1);
            ArrRecipe.Add(recipe2);
            ArrRecipe.Add(recipe3);
            ArrRecipe.Add(recipe4);
        }

        public string ReadAllRecipes()
        {
            string str = "";
            foreach (Recipe item in ArrRecipe)
                str += JsonConvert.SerializeObject(item);

            return str;
        }

        public void Create(Recipe item)
        {
            ArrRecipe.Add(item);
        }

        /*public void Read(string recipeTitle) // READ BY TITLE ONLY
        {
            return ArrRecipe.Find(x => x.Title == recipeTitle);
        }
        public void Update(Recipe recipe)
        {
            ArrRecipe.Find(x => x.Title == recipe.Title) = recipe;
        }
        public void Remove()*/
    }
}
