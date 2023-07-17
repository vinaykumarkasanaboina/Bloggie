namespace Bloggie.Models.Domain
{
    public record BlogPostComment(Guid Id, string Description, Guid BlogPostId, Guid UserId, DateTime DateAdded);
}
