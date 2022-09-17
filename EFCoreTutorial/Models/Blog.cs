using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreTutorial.Models
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }

        //navigation properties
        public User User { get; set; } // 1 to 1
        public ICollection<Post> Posts { get; set; } // 1 to many
        public ICollection<Image> Images { get; set; } // many to many
    }
}
