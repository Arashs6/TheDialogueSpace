namespace TheDialogueSpace.Data.Froum;

internal class Topic
{
    public long Id { get; set; }
    public string Title { get; set; }
    public DateTime CreateAt { get; set; }
    public long UserId { get; set; }
    public long CategoryId { get; set; }
    public bool IsLocked { get; set; }
}