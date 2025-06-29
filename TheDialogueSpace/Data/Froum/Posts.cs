namespace TheDialogueSpace.Data.Froum;

internal class Posts
{
    public long Id { get; set; }
    public string Content { get; set; }
    public DateTime CreateAt { get; set; }
    public long UserId { get; set; }
    public long TopicId { get; set; }
}