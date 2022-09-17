namespace EFCoreTutorial.Models
{
    public class Image
    {
        public int ImageId { get; set; }
        public string Url { get; set; }
        //navigation properties
        public ICollection<Blog> Blogs { get; set; } // many to many
    }
}
