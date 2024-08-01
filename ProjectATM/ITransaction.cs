namespace ProjectATM
{
    public interface ITransaction
    {
        void RecordTransaction(decimal amount);
        void ShowLastFiveTransactions();
        void WithdrawMoney(IUserService user);
        void SetCurrentCardId(string cardId);
    }
}