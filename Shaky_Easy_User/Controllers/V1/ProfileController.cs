using Microsoft.AspNetCore.Mvc;
using Shaky_Easy_User.Contracts.V1;
using Shaky_Easy_User.Domain;
using Shaky_Easy_User.Services;
using static Shaky_Easy_User.Contracts.V1.ApiRoutes;

namespace Shaky_Easy_User.Controllers.V1
{
    public class ProfileController : ControllerBase
    {
        private readonly IProfileService profileService;

        public ProfileController(IProfileService profileService)
        {
            this.profileService = profileService;
        }

        [HttpGet(ApiRoutes.Profiles.GetAll)]
        public IActionResult GetAll()
        {
            var profiles = profileService.GetProfiles();

            if(profiles is not null) return Ok(profiles);

            return NoContent();
        }

        [HttpGet(ApiRoutes.Profiles.Get)]
        public IActionResult Get([FromRoute] Guid id)
        {
            var profile = profileService.GetProfileById(id);

            if (profile is not null) return Ok(profile);

            return NotFound();
            
        }

        [HttpPost(ApiRoutes.Profiles.Post)]
        public IActionResult Post([FromBody] CreateProfileRequest profileRequest)
        {
            var profile = new Profile( Guid.NewGuid(), profileRequest.name);

            profileService.CreateProfile(profile);

            var baseUrl = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host.ToUriComponent()}";

            var location = baseUrl + ApiRoutes.Profiles.Get.Replace("{id:Guid}", profile.Id.ToString()) ;

            var profileResponse = new ProfileResponse(profile.Id, profile.Name);

            return Created(location, profileResponse);
        }

        [HttpPut(ApiRoutes.Profiles.Put)]
        public IActionResult Put([FromRoute] Guid id, [FromBody] UpdateProfileRequest profileRequest)
        {
            var profile = new Profile(id, profileRequest.name);

            var updated = profileService.UpdateProfile(profile);

            if (updated)  return Ok(profile);

            return NotFound();
        }

        [HttpDelete(ApiRoutes.Profiles.Delete)]
        public IActionResult Delete([FromRoute] Guid id)
        {
            var deleted = profileService.DeleteProfile(id);

            if (deleted) return NoContent();

            return NotFound();

        }
    }
}
