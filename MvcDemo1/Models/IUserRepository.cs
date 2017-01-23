using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcDemo1.Models
{
    public interface IUserRepository
    {
        List<UserModel> Users  { get; }
        UserModel GetUserBy(int Id);

        void CreateUser(UserModel user);

        void UpdateUser(UserModel user);

        void DeleteUser(int Id);

        List<UserModel> ListUsers();
    }
}