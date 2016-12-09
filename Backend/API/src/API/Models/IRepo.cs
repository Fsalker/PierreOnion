namespace API.Models
{
    public interface IRepo
    {
        string ReadAllRecipes();
        void Create(Recipe item);
        //void Read();
        //void Update(string key, string name);
        //void Delete(Recipe key);
    }
}
