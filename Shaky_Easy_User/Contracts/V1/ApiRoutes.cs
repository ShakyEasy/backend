namespace Shaky_Easy_User.Contracts.V1
{
    public static class ApiRoutes
    {
        private const string _root = "api";

        private const string _version = "v1";

        private const string _base = _root + "/" + _version;


        public static class Profiles
        {
            public const string GetAll = _base + "/profiles"; // http://localhost:5295/api/v1/profiles

            public const string Get = _base + "/profiles/{id:Guid}";

            public const string Post = _base + "/profiles";

            public const string Put = _base + "/profiles/{id:Guid}";

            public const string Delete = _base + "/profiles/{id:Guid}";

        }
    }
}
