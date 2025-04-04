namespace ShopStar.Comment.Entities
{
    public class UserComment
    {
        public int UserName { get; set; }
        public string NameSureName { get; set; }
        public string? ImageUrl { get; set; }
        public string Email { get; set; }
        public string CommentDetail { get; set; }
        public int Rating { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Status { get; set; }
    }
}
