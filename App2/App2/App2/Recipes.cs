using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    public class Recipes
    {
        public string Name { get; set; }
        public string PhotoUrl { get; set; }

        public Recipes (string Name, string PhotoUrl)
        {
            this.Name = Name;
            this.PhotoUrl = PhotoUrl;
            
        }
    }
}
