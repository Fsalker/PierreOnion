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
            /*Ingredient ingredient1 = new Ingredient(0, "Lapte", 500, "ml");
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
            ArrRecipe.Add(recipe4);*/

            List<string> steps1 = new List<string>();
            steps1.Add("1.Dizolvam drojdia in 50 ml lapte caldut.Restul de lapte il incalzim impreuna cu zaharul, atat doar cat acesta sa se topeasca. Dam deoparte, lasam sa se racoreasca si adaugam esenta de vanilie.");
            steps1.Add("2.Intr - un castron punem faina pe care o amestecam cu drojdia inmuiata in lapte, oul, untul topit, praful de sare, coaja rasa de lamaie si laptele caldut. Framantam aluatul pana cand se omogenizeaza, dupa care adaugam uleiul si mai framantam 5 - 10 minute pana se desprinde de pe peretii vasului. Lasam aluatul sa creasca la cald pana isi dubleaza volumul, cam 50 - 60 de minute.");
            steps1.Add("3.Din aluatul crescut intindem o foaie de 5 - 6 mm grosime. Taiem gogosile cu un pahar mare (diametru 7 - 8cm) si le lasam sa creasca aproximativ 30 de minute, apoi le prajim pe ambele parti in ulei incins. Le scoatem pe un servet de hartie ca sa se absoarba uleiul de la prajit.");
            steps1.Add("4.Dupa ce s-au racorit, le pudram cu zahar si le servim.");

            List<string> steps2 = new List<string>();
            steps2.Add("1.Se adauga bomba");
            steps2.Add("2.Intr - un castron punem faina pe care o amestecam cu drojdia inmuiata in lapte, oul, untul topit, praful de sare, coaja rasa de lamaie si laptele caldut. Framantam aluatul pana cand se omogenizeaza, dupa care adaugam uleiul si mai framantam 5 - 10 minute pana se desprinde de pe peretii vasului. Lasam aluatul sa creasca la cald pana isi dubleaza volumul, cam 50 - 60 de minute.");
            steps2.Add("3.Dizolvam drojdia in 50 ml lapte caldut.Restul de lapte il incalzim impreuna cu zaharul, atat doar cat acesta sa se topeasca. Dam deoparte, lasam sa se racoreasca si adaugam esenta de vanilie.");
            steps2.Add("4.Dupa ce s-au racorit, le pudram cu zahar si le servim.");

            ArrRecipe.Add(new Recipe(0, "Gogoasa", "http://velpitar.ro/wp-content/uploads/2015/02/gogoasa.jpg", "Minunata gogoasa magnifica", steps1));
            ArrRecipe.Add(new Recipe(1, "Ogoasag", "http://4.bp.blogspot.com/-wTdORnU4dzU/VDI9VVYQTlI/AAAAAAAAG04/pAHj-YejlXw/s1600/gogoasa.JPG", "Varianta americana a gogosii", steps2));
        }

        public List<Recipe> ReadAllRecipes()
        {
            return ArrRecipe;
        }
        
        public Recipe ReadRecipeById(int id)
        {
            return ArrRecipe.Find(x => x.Id == id);
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
