using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipeSystem;

namespace RecipeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        [HttpGet]
        public List<bizRecipe> Get()
        {
            return new bizRecipe().GetList();
        }
        [HttpGet("getbycookbook/{cookbookname}")]
        public List<bizRecipe> GetByCookbook(string cookbookname)
        {
            bizRecipe r = new() ;
            return r.GetByCookBook(cookbookname);
            
        }
        [HttpGet("getbycuisine/{cuisineid:int}")]
        public List<bizRecipe> GetByCuisine(int cuisineid)
        {
            bizRecipe r = new();
            return r.GetByCuisine(cuisineid);

        }
    }
}
