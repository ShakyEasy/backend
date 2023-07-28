using Shaky_Easy_User.Domain;

namespace Shaky_Easy_User.Services
{
    public interface IProfileService
    {
        List<Profile>? GetProfiles();

        Profile? GetProfileById(Guid id);

        Profile CreateProfile(Profile profile);

        bool UpdateProfile(Profile profile);

        bool DeleteProfile(Guid id);
    }
}
