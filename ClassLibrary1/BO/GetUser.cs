using Calculator.Data.Repos.BO;
using Calculator.UserManager.DTO;
using Calculator.UserManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator.UserManager.BO
{
   public class GetUser: IUserManager<User, User>
    {
        public User Manage(User value)
        {

            try
            {
                using (var db = new UnitOfWorkForCalculatorDb(null))
                {
                    var users = db.UserRepository.GetAll().Where(x => x.Password == value.Password && x.UserName == value.UserName).Select(a => new User
                    {

                        Password = a.Password,
                        IsValid = a.IsValid,
                        UserID = a.UserID,
                        UserName = a.UserName


                    }).FirstOrDefault();

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
