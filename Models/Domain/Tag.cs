using System.Security.Cryptography;

namespace Blog_Posting_with_C_.Models.Domain
{
    public class Tag
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public int MyProperty { get; set; }

        public ICollection<BlogPost>  BlogPosts { get; set; }
    }
}
