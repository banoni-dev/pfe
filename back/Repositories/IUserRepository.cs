using back.Models;
using System.Collections.Generic;

namespace back.Repositories
{
    public interface IUserRepository
    {
        UserModel GetUserById(int id);
        UserModel GetUserByEmail(string email);
        List<UserModel> GetAllUsers();
        UserModel CreateUser(UserModel user);
        UserModel UpdateUser(int id, UserModel updatedUser);
        void DeleteUser(int id);
    }
}
