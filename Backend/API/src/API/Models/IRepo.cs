using System.Collections.Generic;

namespace API.Models
{
    public interface IRepo
    {
        List<Recipe> ReadAllRecipes();
        Recipe ReadRecipeById(int id);
        void Create(Recipe item);
        //void Read();
        //void Update(string key, string name);
        //void Delete(Recipe key);
    }
}
