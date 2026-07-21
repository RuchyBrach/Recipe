using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipeSystem;

namespace RecipeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CookBookController : ControllerBase
    {
        [HttpGet]
        public List<bizCookBook> Get()
        {
            return new bizCookBook().GetList();
        }
        [HttpGet("{id:int:min(0)}")]
        public bizCookBook Get(int id)
        {
            bizCookBook c = new();
            c.Load(id);
            return c;
        }
    }
}
