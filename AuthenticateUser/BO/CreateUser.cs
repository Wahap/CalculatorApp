using System;
using AuthenticateUser.Interfaces;

using System.Collections.Generic;
using System.Linq;
using Calculator.UserManager.DTO;
using Calculator.Data.Repos.BO;

namespace AuthenticateUser.BO
{
    public class CreateUser : IAuthenticationManager<List<User>, User>
    {
        public List<User> Manage(User value)
        {

            try
            {
                using (var db = new UnitOfWorkForCalculatorDb(null))
                {
                    List<User> users = db.UserRepository.GetAll().ToList();

                    return users;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
