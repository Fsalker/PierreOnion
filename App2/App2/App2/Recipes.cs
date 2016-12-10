using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    public class Recipes
    {
        public string Name { get; set; }
        public string PhotoUrl { get; set; }
        public int Id { get; set; }
        public string Description { get; set; }
        public List<string> Steps { get; set; }
        public List<string> Ingredients { get; set; }

        public Recipes (string Name, string PhotoUrl, int Id, string Description, List<string> Steps, List<string> Ingredients)
        {
            this.Name = Name;
            this.PhotoUrl = PhotoUrl;
            this.Id = Id;
            this.Description = Description;
            this.Steps = Steps;
            this.Ingredients = Ingredients;                                                          
        }

   
    }
}
