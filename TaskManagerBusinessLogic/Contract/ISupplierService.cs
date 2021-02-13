namespace TaskManagerBusinessLogic.Contract
{
    public interface ISupplierService
    {
        void SendMessage(string message, int taskId);
    }
}