using System.Collections.Generic;
using System;

namespace API.Models
{
    public interface IRepo
    {
        List<Recipe> ReadAll();
        Recipe Read(int id);
        void Create(Recipe item);
        //void Read();
        //void Update(string key, string name);
        //void Delete(Recipe key);
    }
}
