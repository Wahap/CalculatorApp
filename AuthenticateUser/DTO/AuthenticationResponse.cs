namespace AuthenticateUser.DTO
{
    public class AuthenticationResponse
    {
        public User User { get; set; }
        public string ReponseText { get; set; } = "";
        public string AuthToken { get; set; } = "";

    }
}
