using back.Models;
using back.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace back.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly Db _db;

        public UserRepository(Db db)
        {
            _db = db;
        }

        public UserModel GetUserById(int id)
        {
            return _db.Users.FirstOrDefault(u => u.Id == id);
        }

        public UserModel GetUserByEmail(string email)
        {
            return _db.Users.FirstOrDefault(u => u.Email == email);
        }

        public List<UserModel> GetAllUsers()
        {
            return _db.Users.ToList();
        }

        public UserModel CreateUser(UserModel user)
        {
            _db.Users.Add(user);
            _db.SaveChanges();
            return user;
        }

        public UserModel UpdateUser(int id, UserModel updatedUser)
        {
            var user = _db.Users.FirstOrDefault(u => u.Id == id);
            if (user == null)
                throw new Exception("User not found");

            user.FirstName = updatedUser.FirstName;
            user.LastName = updatedUser.LastName;
            user.Email = updatedUser.Email;
            user.Telephone = updatedUser.Telephone;
            user.Password = updatedUser.Password;

            _db.SaveChanges();
            return user;
        }

        public void DeleteUser(int id)
        {
            var user = _db.Users.FirstOrDefault(u => u.Id == id);
            if (user == null)
                throw new Exception("User not found");

            _db.Users.Remove(user);
            _db.SaveChanges();
        }
    }
}
