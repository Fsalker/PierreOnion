﻿using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace App2
{
      public class Request
     {
        public async Task<List<Recipes>> GetRecipes()
        {
            using (HttpClient client = new HttpClient())
            {
                //client.BaseAddress = new Uri($"http://pierreapi.azurewebsites.net/api/recipe");

                HttpResponseMessage response = await client.GetAsync("http://pierreapi.azurewebsites.net/api/recipe");

                string text =  await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<List<Recipes>>(text);
            }
        }

        
        public async Task<Recipes> GetRecipeById(int Id)
        {
            using (HttpClient client = new HttpClient())
            {
                //client.BaseAddress = new Uri($"http://pierreapi.azurewebsites.net/api/recipe");

                HttpResponseMessage response;

                string x = "http://pierreapi.azurewebsites.net/api/recipe/" + Id.ToString();

                response = await client.GetAsync(x);

                string text = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<Recipes>(text);
            }
        }

    }
    }
