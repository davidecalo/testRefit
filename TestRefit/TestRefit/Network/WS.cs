using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Refit;
using Service.Shared.Clients;

namespace TestRefit.Network
{
    public class WS
    {
        public WS()
        {
        }

        public async Task<List<Recipe>> CallService()
        {

            var httpClient = new HttpClient(new HttpLoggingHandler())
            {
                BaseAddress = new Uri("http://www.recipepuppy.com")
            };

            var api = RestService.For<IRecipePuppy>(httpClient /*, new RefitSettings
            {
                JsonSerializerSettings = new JsonSerializerSettings()
                {
                    ContractResolver = new CamelCasePropertyNamesContractResolver()
                }
            }*/);
            /*
            /*
            api.GetRecipeListJson("pizza", "1").ContinueWith((arg) =>
            {
                Debug.Write("*************** " + arg.Result);
            });*/

            RecipeResponse recipeResponse = await api.GetRecipeList("pizza", "1");
            return ConvertResponse(recipeResponse);
        }

        private List<Recipe> ConvertResponse(RecipeResponse recipeResponse)
        {
            List<Recipe> recipes = new List<Recipe>();
            foreach (Item item in recipeResponse.Items)
            {
                recipes.Add(new Recipe(item.title));
            }
            return recipes;
        }

    }
}
