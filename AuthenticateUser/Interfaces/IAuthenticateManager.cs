namespace AuthenticateUser.Interfaces
{
    public interface IAuthenticateManager<T1, T2>
    {
        T1 Manage(T2 value);
    }
}
