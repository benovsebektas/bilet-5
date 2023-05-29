namespace bilet_5.Models
{
    public class TeamMember
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Position { get; set; }
        public string ImagePath { get; set; }
        public string Title { get; set; }
        public List<SocialMedia> socials { get; set;}

    }
}
