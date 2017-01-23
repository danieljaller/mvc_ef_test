using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace MvcDemo1.Models
{
    public class UserRepository : IUserRepository
    {
        
        private readonly List<UserModel> _users = new List<UserModel>();

        public List<UserModel> Users => _users;

        public UserRepository()
        {
            Users.Add(new UserModel
            {
                Id = 1,
                FirstName = "Arne",
                LastName = "Anka",
                Address = "Gatan",
                Email = "anka@anka.se",
                DateOfBirth = Convert.ToDateTime("4/20/1987"),
                Salary = 5000
            });
            Users.Add(new UserModel
            {   
                Id = 2,
                FirstName = "Daniel",
                LastName = "Jaller",
                Address = "Hejsangatan",
                Email = "banka@olle.se",
                DateOfBirth = Convert.ToDateTime("12/20/1988"),
                Salary = 7000
            });
        }

        public UserModel GetUserBy(int id)
        {
            return Users.FirstOrDefault(u => u.Id.Equals(id));
        }

        public void CreateUser(UserModel user)
        {
            int highestPreviousId = Users.OrderBy(u => u.Id).Last().Id;
            user.Id = highestPreviousId + 1;
            Users.Add(user);
        }

        public void UpdateUser(UserModel updatedUser)
        {
            
            foreach (var user in Users)
            {
                if (user.Id == updatedUser.Id)
                {
                    Users.Remove(user);
                    Users.Add(updatedUser);
                    break;
                }
            }
        }

        public void DeleteUser(int id)
        {
            Users.Remove(GetUserBy(id));
        }

        public List<UserModel> ListUsers()
        {
            return Users;
        }

    }
}
