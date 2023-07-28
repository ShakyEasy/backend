namespace Shaky_Easy_User.Contracts.V1
{
    public static class ApiRoutes
    {
        private const string _root = "api";

        private const string _version = "v1";

        private const string _base = _root + "/" + _version;


        public static class Profile
        {
            public const string GetAll = _base + "/profiles";

            public const string Get = _base + "/profiles/{id}";

            //public const string Post = _base + "/profile/{id}";

        }
    }
}
