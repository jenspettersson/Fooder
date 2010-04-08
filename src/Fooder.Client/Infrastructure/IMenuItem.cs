namespace Fooder.Client.Infrastructure
{
    public interface IMenuItem
    {
        string ItemName { get; }
        
        //Note: Temporary
        bool Activated { get; }
        
        void Open();
    }
}