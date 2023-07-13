namespace EFCoreRelationshipsTutorial
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;

        //One-to-many relationship
        public List<Character> Characters { get; set; }
    }
}
