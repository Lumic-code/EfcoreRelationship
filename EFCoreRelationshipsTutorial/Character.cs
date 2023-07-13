using System.Text.Json.Serialization;

namespace EFCoreRelationshipsTutorial
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string RpgClass { get; set; } = "Knight";

        //One-to-many relationship
        //JsonIgnore was used to ignore the object User.
        [JsonIgnore]
        public User User { get; set; }
        public int UserId { get; set; }

        //One-to-one relationship
        public Weapon Weapon { get; set; }

        //many-to-many relationship
        public List<Skill> Skills { get; set; }
       
    }
}
