namespace NorthwindMVC.Website.Models.Base
{
    public interface ICanShowAsCard : IAmClickable
    {
        int Id { get; }
        string Title { get; }
        string Text { get; }
        string Image { get; }
    }
}
