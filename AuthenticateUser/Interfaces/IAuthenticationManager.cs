namespace AuthenticateUser.Interfaces
{
    public interface IAuthenticationManager<T1, T2>
    {
        T1 Manage(T2 value);
    }
}
