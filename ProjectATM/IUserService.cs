
namespace ProjectATM
{
    public interface IUserService
    {
        bool IsCardValid(string cardId);
        bool Authenticate(string password);
        decimal Balance { get; }
        void UpdateBalance(decimal newBalance);
    }
}