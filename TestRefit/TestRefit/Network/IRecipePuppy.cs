using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;

namespace TestRefit.Network
{
    public interface IRecipePuppy
    {

        [Get("/api/")]
        Task<RecipeResponse> GetRecipeList([AliasAs ("q")] string query, [AliasAs("p")] string page );

        [Get("/api/")]
		Task<string> GetRecipeListJson([AliasAs("q")] string query, [AliasAs("p")] string page);
    }
}
