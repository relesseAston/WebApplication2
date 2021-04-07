using System;
using System.Collections.Generic;
using WebApplication2.Models;

namespace WebApplication2
{
    public interface IUserDao
    {
        public List<User> GetAllUser();
        public User GetUserById(long id_user);
        public void CreateUser(User user);
        public void DeleteUser(long id_user);

    }
}
