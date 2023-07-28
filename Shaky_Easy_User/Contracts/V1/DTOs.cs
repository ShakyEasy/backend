namespace Shaky_Easy_User.Contracts.V1
{
    public class DTOs
    {
        #region Profile

        #region responses
        public record GetProfileResponse(Guid Id, string name);


        #endregion

        #region requests
        
        public record CreateProfileRequest(string name);


        #endregion


        #endregion
    }
}
