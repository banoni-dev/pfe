using back.Models;
using System.Collections.Generic;

namespace back.Services
{
    public interface IUserService
    {
        UserModel GetUserById(int id);
        UserModel GetUserByEmail(string email);
        List<UserModel> GetAllUsers();
        UserModel CreateUser(UserModel user);
        UserModel UpdateUser(int id, UserModel updatedUser);
        void DeleteUser(int id);
    }
}
