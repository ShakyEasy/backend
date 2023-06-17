using Microsoft.AspNetCore.Mvc;
using Shaky_Easy_User.Settings;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Shaky_Easy_User.Controllers
{
    public class ProfileController : ControllerBase
    {
        [HttpGet(ApiRoutes.Profile.GetAll)]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet((ApiRoutes.Profile.Get))]
        public string Get(int id)
        {
            return id.ToString();
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
