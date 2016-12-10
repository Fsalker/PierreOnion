using System.Collections.Generic;

namespace API.Models
{
    public class Recipe
    {
        public int Id { get; set; }
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
        }
    }
}
