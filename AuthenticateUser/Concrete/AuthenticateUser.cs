using AuthenticateUser.BO;
using AuthenticateUser.DTO;
using AuthenticateUser.Interfaces;
using Calculator.Data.Repository.BO;
using Calculator.EncryptionDecryption.BO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AuthenticateUser.Concrete
{
    public class AuthenticateUser : IAuthenticationManager<AuthenticationResponse, AuthenticationRequest>
    {
        public AuthenticationResponse Manage(AuthenticationRequest value)
        {
            try
            {
                var token = Guid.NewGuid().ToString();
                var username = new DecryptionData().Manage(value.Username);
                var password = new DecryptionData().Manage(value.Password);
                using (var db = new UnitOfWorkForCalculatorDb(null))
                {
                    List<User> users = db.UserRepository.GetAll().Where(x => x.UserName == username && x.Password == password).Select(a => new User
                    {

                        Password = a.Password,
                        IsValid = a.IsValid,
                        UserID = a.UserID,
                        UserName = a.UserName


                    }).ToList();

                    if (users.Count == 1)
                    {
                        AuthenticatedUsers.Set(token, new User
                        {
                            UserName = value.Username,
                            Password = value.Password
                        });
                        return new AuthenticationResponse
                        {
                            User = new User { UserName = value.Username, IsValid = true },
                            AuthToken = token,
                            ReponseText = "user authorized"
                        };
                    }
                    else
                    {
                        return new AuthenticationResponse
                        {
                            User = new User { UserName = value.Username, IsValid = false },
                            ReponseText = "User not Authenticated"

                        };
                    }

                }

                //var userlist = securitydb.TblUserRepository.GetAll();
                //var user =
                //    userlist.FirstOrDefault(p => p.UN.ToLower().Trim() == value.Username.ToLower().Trim() &&
                //                                 p.PW.Trim() == value.Password.Trim());

                // Get Products for this user


            }

            catch (Exception ex)
            {
                if (ex.Message.Contains("Base-64")) return new AuthenticationResponse
                {
                    User = new User { UserName = value.Username, IsValid = false },
                    ReponseText = "User not Authenticated"

                };
                return new AuthenticationResponse
                {
                    User = new User { UserName = value.Username, IsValid = false },
                    ReponseText = "StackTrace: " + ex.StackTrace + " Error Message: " + ex.Message

                };
            }

        }
    }
}
