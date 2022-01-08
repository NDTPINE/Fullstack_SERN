namespace UseCases
{
    public interface IRecordTransactionUseCase
    {
        void Execute(int productId, string productName, int quantity, string cashiername);
    }
}