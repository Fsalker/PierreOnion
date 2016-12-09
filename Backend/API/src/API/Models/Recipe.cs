using System.Collections.Generic;

namespace API.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImageURL { get; set; } 
        public string Description { get; set; }
        public float Rating { get; set; }
        public float Difficulty { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public List<Comment> Comments { get; set; }
        public int RequiredTime { get; set; }
        public int Category { get; set; }

        public Recipe(int id, string title, string imageURL, string description, float rating, float difficulty, List<Ingredient> ingredients, List<Comment> comments, int requiredTime, int category)
        {
            Id = id;
            Title = title;
            ImageURL = imageURL;
            Description = description;
            Rating = rating;
            Difficulty = difficulty;
            Ingredients = ingredients;
            Comments = comments;
            RequiredTime = requiredTime;
            Category = category;
        }
    }
}
