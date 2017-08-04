using AuthenticateUser.DTO;
using AuthenticateUser.Interfaces;
using Calculator.Data.Repository.BO;

using System;
using System.Collections.Generic;
using System.Linq;

namespace AuthenticateUser.BO
{
    public class LoadAllUsers : IAuthenticationManager<List<User>, User>
    {
        public List<User> Manage(User value)
        {

            try
            {
                using (var db = new UnitOfWorkForCalculatorDb(null))
                {
                    List<User> users = db.UserRepository.GetAll().Select(a=>new User {

                        Password=a.Password,
                         IsValid=a.IsValid,
                         UserID=a.UserID,
                         UserName=a.UserName


                    }).ToList();

                    return users;
                }
            } 
            catch (Exception e)
            { 

                throw;
            }
        }
    }
}
