using TheDialogueSpace.Data.Froum;

namespace TheDialogueSpace.Services;

internal class ForumService : IForumService
{
    public async Task<List<Category>> GetAllCategories()
    {
        return new List<Category>()
        {
            new Category(){Id = 1,Title = "اقتصاد کلان" },
            new Category(){Id = 1,Title = "اقتصاد خرد" },
            new Category(){Id = 1,Title = "اقتصاد سیاسی" },
            new Category(){Id = 1,Title = "اقتصاد توسعه" },
        };
    }
}