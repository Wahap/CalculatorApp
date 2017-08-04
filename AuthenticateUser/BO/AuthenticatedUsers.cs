using AuthenticateUser.DTO;
using System.Collections.Concurrent;

namespace AuthenticateUser.BO
{
    public static class AuthenticatedUsers
    {
        private static readonly ConcurrentDictionary<string, User> LoggedUsers = new ConcurrentDictionary<string, User>();

        public static void Set(string token, User userInfo)
        {
            if (!IsAuthenticated(token))
            {
                LoggedUsers.AddOrUpdate(token, userInfo, (k, v) => userInfo);
            }
        }

        public static User Get(string token)
        {
            if (token == null)
            {
                return null;
            }

            User userInfo;
            LoggedUsers.TryGetValue(token, out userInfo);
            return userInfo;
        }

        public static void Remove(string token)
        {
            if (token == null)
            {
                return;
            }

            User userInfo;
            LoggedUsers.TryRemove(token, out userInfo);
        }

        public static bool IsAuthenticated(string token)
        {
            return Get(token) != null;
        }
    }
}
