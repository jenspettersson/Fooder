namespace Fooder.Client.Infrastructure
{
    public interface IMenuItem
    {
        string ItemName { get; }
        void Open();
    }
}