namespace Shaky_Easy_User.Settings
{
    public static class ApiRoutes
    {
        public const string _root = "api";

        public const string _version = "";

        public const string _base = _root + "/" + _version;


        public static class Proofile
        {
            public const string GetAll = _base + "/profiles";

            public const string Get = _base + "/profile/{id}";

            //public const string Post = _base + "/profile/{id}";

        }
    }
}
