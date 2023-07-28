namespace Shaky_Easy_User.Domain
{
    public class Profile
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public Profile(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
