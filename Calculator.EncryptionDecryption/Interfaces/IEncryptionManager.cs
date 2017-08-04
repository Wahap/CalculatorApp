namespace Calculator.EncryptionDecryption.Interfaces
{
    public interface IEncryptionManager<T>
    {
        T Manage(T value);
    }
}
