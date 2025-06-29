using System.Security.Principal;

namespace TheDialogueSpace.Data.Froum;

internal class User
{
    public long Id { get; set; }
    public string Email { get; set; }
    public string ProfilePictureUrl { get; set; }
    public DateTime RegistrationDate { get; set; }
    public string Role { get; set; }
}