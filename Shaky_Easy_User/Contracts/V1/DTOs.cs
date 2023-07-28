namespace Shaky_Easy_User.Contracts.V1
{

        #region Profile

        #region responses
        public record ProfileResponse(Guid Id, string name);


        #endregion

        #region requests
        
        public record CreateProfileRequest(string name);

        public record UpdateProfileRequest(string name);

    #endregion


    #endregion
}

