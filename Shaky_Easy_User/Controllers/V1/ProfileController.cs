using Microsoft.AspNetCore.Mvc;
using Shaky_Easy_User.Contracts.V1;

namespace Shaky_Easy_User.Controllers.V1
{
    public class ProfileController : ControllerBase
    {
        [HttpGet(ApiRoutes.Profile.GetAll)]
        public IActionResult Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet(ApiRoutes.Profile.Get)]
        public IActionResult Get(int id)
        {
            return id.ToString();
        }

        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
        }
    }
}
