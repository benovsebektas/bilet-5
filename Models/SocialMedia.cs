namespace bilet_5.Models
{
    public class SocialMedia
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TeamMemberId { get; set; }

        public TeamMember? TeamMember { get; set; }
    }
}
