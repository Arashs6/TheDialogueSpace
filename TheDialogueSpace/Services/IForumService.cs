using TheDialogueSpace.Data.Froum;

namespace TheDialogueSpace.Services;

internal interface IForumService
{
    Task<List<Category>> GetAllCategories();
}