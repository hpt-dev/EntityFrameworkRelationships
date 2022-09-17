namespace EFCoreTutorial.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string Name { get; set; }
        public string Body { get; set; }

        public Blog Blog { get; set; } // 1 to many

    }
}
