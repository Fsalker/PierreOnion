namespace API.Models
{
    using System;

    public class Comment
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Text { get; set; }
        public float Rating { get; set; }
        public DateTime PostDate { get; set; }
        public int RecipeId { get; set; }

        public Comment(int id, string userName, string text, float rating, DateTime postDate, int recipeId)
        {
            Id = id;
            UserName = userName;
            Text = text;
            Rating = rating;
            PostDate = postDate;
            RecipeId = recipeId;
        }
    }
}
