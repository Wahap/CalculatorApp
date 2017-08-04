using System;
using AuthenticateUser.Interfaces;
using Calculator.Data.Repository.Data;
using Calculator.Data.Repository.BO;
using System.Collections.Generic;
using System.Linq;

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
