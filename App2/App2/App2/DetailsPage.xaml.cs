using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App2
{
    public partial class DetailsPage : ContentPage
    {
          int j;
        public DetailsPage(int i)
        {
            InitializeComponent();
            j = i;
            BackgroundColor = Color.FromHex("#FFDAB9");
            title1.TextColor= Color.FromHex("#B22222");
            title2.TextColor = Color.FromHex("#B22222");
            title3.TextColor = Color.FromHex("#B22222");
        }

      

        private async void On_Appearing(object sender, EventArgs e)
        {
            Request request = new Request();
            Recipes recipe = await request.GetRecipeById(j);
            nameLabel.Text = recipe.Name;
            image.Source = recipe.PhotoUrl;
            descriptionLabel.Text = recipe.Description;
            stepsLabel.Text = String.Join("\n", recipe.Steps);
            ingredientsLabel.Text= String.Join("\n", recipe.Ingredients);

        }
    }


        


    }

