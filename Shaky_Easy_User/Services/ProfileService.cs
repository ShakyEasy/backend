using Shaky_Easy_User.Domain;

namespace Shaky_Easy_User.Services
{
    public class ProfileService : IProfileService
    {
        public List<Profile> _profiles = new() {
        
            new Profile(new Guid("19cc8c1e-a65f-4a2c-905f-aa5186808a2c"), "profile1"),
            new Profile(new Guid("218c7226-ff45-4fb0-9c41-7903e4219d08"), "profile2"),
            new Profile(new Guid("ae927db7-0315-4d2f-a3cd-09d7b9756fdc"), "profile3"),
        };

        public ProfileService()
        {
                
        }
        public Profile CreateProfile(Profile profile)
        {
            _profiles.Add(profile);

            return profile;
        }

        public bool DeleteProfile(Guid id)
        {
            return _profiles.Remove(_profiles.Where(profile => profile.Id == id).First());

        }

        public Profile? GetProfileById(Guid id)
        {
            return _profiles.FirstOrDefault(profile => profile.Id == id);
        }

        public List<Profile>? GetProfiles()
        {
            return _profiles.Count > 0 ? _profiles : null;
            
        }

        public bool UpdateProfile(Profile profile)
        {
            var index = _profiles.FindIndex(p => p.Id == profile.Id);

            if (index == -1)
            {
                return false;
            }

            _profiles[index] = profile;

            return true;

        }
    }
}
