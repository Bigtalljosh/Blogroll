namespace Blogroll
{
    public class BlogSettings
    {
        public string Name { get; set; } = "Blogroll";
        public string Description { get; set; } = "The musings and experiments of a developer.";
        public string Owner { get; set; } = "Josh Dadak";
        public int PostsPerPage { get; set; } = 5;
        public int CommentsCloseAfterDays { get; set; } = 10;
    }
}
