using System.Collections.Generic;

namespace API.Models
{
    public class Recipe
    {
        public int Id { get; set; }
<<<<<<< HEAD
        public string Name { get; set; }
        public string PhotoUrl { get; set; }
        public string Description { get; set; }
        public List<string> Steps { get; set; }

        public Recipe(int id, string name, string photoUrl, string description, List<string> steps)
        {
            Id = id;
            Name = name;
            PhotoUrl = photoUrl;
            Description = description;
            Steps = steps;
=======
        public string Title { get; set; }
        public string ImageURL { get; set; } 
        //public string Description { get; set; }
        //public float Rating { get; set; }
        //public float Difficulty { get; set; }
        //public List<Ingredient> Ingredients { get; set; }
        //public List<Comment> Comments { get; set; }
        //public int RequiredTime { get; set; }
        //public int Category { get; set; }

        public Recipe(int id, string title, string imageURL)
        {
            Id = id;
            Title = title;
            ImageURL = imageURL;
            //Description = description;
            //Rating = rating;
            //Difficulty = difficulty;
            //Ingredients = ingredients;
            //Comments = comments;
            //RequiredTime = requiredTime;
            //Category = category;
>>>>>>> origin/master
        }
    }
}
