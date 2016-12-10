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
               );
            Recipe recipe2 = new Recipe(1, "Bomba gogoasa", "http://www.click.ro/sites/default/files/styles/articol/public/medias/2016/02/09/gogosi-cu-crema-de-vanilie-si-ciocolata-580x400.jpg?itok=6CsQizOI",
               );
            Recipe recipe3 = new Recipe(2, "Ogosi bombag", "http://www.click.ro/sites/default/files/styles/articol/public/medias/2016/02/09/gogosi-cu-crema-de-vanilie-si-ciocolata-580x400.jpg?itok=6CsQizOI",
               );
            Recipe recipe4 = new Recipe(3, "Mai multe gogosi", "http://www.click.ro/sites/default/files/styles/articol/public/medias/2016/02/09/gogosi-cu-crema-de-vanilie-si-ciocolata-580x400.jpg?itok=6CsQizOI",
                );

            ArrRecipe.Add(recipe1);
            ArrRecipe.Add(recipe2);
            ArrRecipe.Add(recipe3);
            ArrRecipe.Add(recipe4);*/

            /*List<string> steps1 = new List<string>();
            steps1.Add("1.Dizolvam drojdia in 50 ml lapte caldut.Restul de lapte il incalzim impreuna cu zaharul, atat doar cat acesta sa se topeasca. Dam deoparte, lasam sa se racoreasca si adaugam esenta de vanilie.");
            steps1.Add("2.Intr - un castron punem faina pe care o amestecam cu drojdia inmuiata in lapte, oul, untul topit, praful de sare, coaja rasa de lamaie si laptele caldut. Framantam aluatul pana cand se omogenizeaza, dupa care adaugam uleiul si mai framantam 5 - 10 minute pana se desprinde de pe peretii vasului. Lasam aluatul sa creasca la cald pana isi dubleaza volumul, cam 50 - 60 de minute.");
            steps1.Add("3.Din aluatul crescut intindem o foaie de 5 - 6 mm grosime. Taiem gogosile cu un pahar mare (diametru 7 - 8cm) si le lasam sa creasca aproximativ 30 de minute, apoi le prajim pe ambele parti in ulei incins. Le scoatem pe un servet de hartie ca sa se absoarba uleiul de la prajit.");
            steps1.Add("4.Dupa ce s-au racorit, le pudram cu zahar si le servim.");

            List<string> ingredients1 = new List<string>();
            ingredients1.Add("100 ml apa");
            ingredients1.Add("250 g gogosi");

            List<string> steps2 = new List<string>();
            steps2.Add("1.Se adauga bomba");
            steps2.Add("2.Intr - un castron punem faina pe care o amestecam cu drojdia inmuiata in lapte, oul, untul topit, praful de sare, coaja rasa de lamaie si laptele caldut. Framantam aluatul pana cand se omogenizeaza, dupa care adaugam uleiul si mai framantam 5 - 10 minute pana se desprinde de pe peretii vasului. Lasam aluatul sa creasca la cald pana isi dubleaza volumul, cam 50 - 60 de minute.");
            steps2.Add("3.Dizolvam drojdia in 50 ml lapte caldut.Restul de lapte il incalzim impreuna cu zaharul, atat doar cat acesta sa se topeasca. Dam deoparte, lasam sa se racoreasca si adaugam esenta de vanilie.");
            steps2.Add("4.Dupa ce s-au racorit, le pudram cu zahar si le servim.");

            List<string> ingredients2 = new List<string>();
            ingredients2.Add("500 ml lapte");
            ingredients2.Add("1.5 kg usturoi");

            ArrRecipe.Add(new Recipe(0,"Gogoasa", "http://velpitar.ro/wp-content/uploads/2015/02/gogoasa.jpg", "Minunata gogoasa magnifica", steps1, ingredients1));
            ArrRecipe.Add(new Recipe(1,"Ogoasag", "http://4.bp.blogspot.com/-wTdORnU4dzU/VDI9VVYQTlI/AAAAAAAAG04/pAHj-YejlXw/s1600/gogoasa.JPG", "Varianta americana a gogosii", steps2, ingredients2));*/

            //ArrRecipe.Add(new Recipe(0, "", "", "", steps, ingredients));

            String url1 = "http://homecookingadventure.com/images/recipes/apple-roll_ups_main.jpg ";
            String desc1 = "Slices of bread, filled with delicious cream cheese and apple cinnamon mixture";
            List<string> ing1 = new List<string>();
            ing1.Add("2 medium apples, peeled, cored and cut in small pieces");
            ing1.Add("1 / 2 tsp(1.5g) cinnamon");
            ing1.Add("2 tsp(10ml) lemon juice");
            ing1.Add("2 eggs");
            ing1.Add("3 tbsp(45ml) milk");
            ing1.Add("10 - 12 toast bread slices");
            ing1.Add("4 oz(120g) cream cheese, room temperature");
            ing1.Add("1 tsp(3g) ground cinnamon");
            ing1.Add("2 tbsp(28g) butter, for cooking");
        
            List<string> steps1 = new List<string>();
            steps1.Add("1.Place apple pieces, cinnamon and lemon juice in a small saucepan.Cook over low - heat for about 3 minutes, until apples start to soften.Transfer apples into a bowl and set aside to cool until ready to use.");
            steps1.Add("2.In a bowl combine sugar with cinnamon and set aside.In another bowl beat eggs with milk and set aside.");
            steps1.Add("3.Remove crust from each slice of bread and flatten using a rolling pin.");
            steps1.Add("4.Spread cream cheese evenly on each slice of bread.");
            steps1.Add("5.Add about 1 - 2 tsp of apples and roll up each slice.");
            steps1.Add("6.Heat a non-stick pan over medium heat and melt about 1 tbsp of butter.");
            steps1.Add("7.Dip each roll in egg mixture and cook on each side until golden brown. Cook 3 - 4 roll at a time. Clean the pan slightly with a paper towel and repeat until all rolls are cooked.");
            steps1.Add("8.Roll into the sugar cinnamon mixture.");
            steps1.Add("9.Serve warm and dip in maple syrup if desired.");

            String url2 = "http://www.potatopro.com/sites/default/files/pictures/french-fries-1200.jpg";
            String desc2 = "French-fried potatoes";
            List<string> ing2 = new List<string>();
            ing2.Add("5 pounds russet potatoes");
            ing2.Add("Vegetable or peanut oil, for frying");
            ing2.Add("Sea salt");
       
            List <string> steps2 = new List<string>();
            steps2.Add("Peel and rinse the potatoes.Then cut them into sticks by cutting the potato in 4 or 5 vertical pieces, and then cutting each piece into sticks. ");
            steps2.Add("Place them in a large bowl and cover with cold water. Allow them to soak, 2 to 3 hours. (You can also stick them in the fridge and let them soak overnight.)");
            steps2.Add("When you're ready to make the fries, drain off the water and lay the potatoes on 2 baking sheets lined with paper towels. Blot with paper towels to dry them. ");
            steps2.Add("Heat a few inches of oil in a heavy pot to 300 degrees F. In 3 or 4 batches, cook the potatoes until soft, 4 to 5 minutes per batch.They should not be brown at this point!You just want to start the cooking process.Remove each batch and drain on new/ dry paper towels. ");
            steps2.Add("Once all the potatoes have been fried at 300 degrees F, turn up the heat until the oil reaches 400 degrees F. When the oil's hot, start frying the potatoes in batches again, cooking until the fries are golden and crisp. Remove the potatoes from the oil and drain on paper towels. ");
            steps2.Add("Sprinkle with sea salt and dive in!");
            
            String url3 = "http://assets.simplyrecipes.com/wp-content/uploads/2009/09/caesar-salad-horiz-800.jpg";
            String desc3 = "Romaine lettuce and croutons dressed with parmesan cheese, lemon juice, olive oil, egg, Worcestershire sauce, garlic, and black pepper.";
            List<string> ing3 = new List<string>();
            ing3.Add("1 medium ciabatta loaf (or 4 thick slices crusty white bread)");
            ing3.Add("3 tbsp olive oil");
            ing3.Add("2 skinless, boneless chicken breast");
            ing3.Add("1 large cos or romaine lettuce, leaves separated");
            ing3.Add("1 garlic clove");
            ing3.Add("2 anchovy");
            ing3.Add("medium block Parmesan");
            ing3.Add("5 tbsp mayonnaise");
            ing3.Add("1 tbsp white wine vinegar");

            List<string> steps3 = new List<string>();
            steps3.Add("1.Heat oven to 200C / fan 180C / gas 6.Tear the bread into big, ragged croutons or, if you prefer, cut with a bread knife.Spread over a large baking sheet or tray and sprinkle over 2 tbsp olive oil.Rub the oil into the bread and season with a little salt if you like(sea salt crystals are best for this).Bake for 8 - 10 mins, turning the croutons a few times during cooking so they brown evenly.");
            steps3.Add("2.Rub chicken breasts with remaining oil, season.Place pan over a medium heat for 1 min, until hot, but not smoking.Lay the chicken on the pan(it will sizzle if it’s hot enough) and leave for 4 mins.Turn the chicken, then cook for 4 mins more.Check if it’s cooked by poking the tip of a sharp knife into the thickest part; there should be no sign of pink and juices will run clear.");
            steps3.Add("3.Bash the garlic with the flat of a knife and peel off the skin.Crush with a garlic crusher.Mash the anchovies with a fork against the side of a small bowl.Grate a handful of cheese and mix with the rest of the dressing ingredients. Season to taste.It should be the consistency of yogurt – if yours is thicker, stir in a few tsps water to thin it.");
            steps3.Add("4.Shave the cheese with a peeler.Tear lettuce into large pieces and put in a large bowl.Pull chicken into bite-size strips and scatter half over the leaves, along with half the croutons.Add most of the dressing and toss with your fingers. Scatter the rest of the chicken and croutons, then drizzle with the remaining dressing.Sprinkle the Parmesan on top and serve straight away.");

            

            ArrRecipe.Add(new Recipe(0, "French Apple Rolls", url1 , desc1, steps1, ing1));
            ArrRecipe.Add(new Recipe(1, "French Fries", url2, desc2, steps2, ing2));
            ArrRecipe.Add(new Recipe(2, "Cesar salad", url3, desc3, steps3, ing3));
        }

        public List<Recipe> ReadAll()
        {
            return ArrRecipe;
        }
        
        public Recipe Read(int id)
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
