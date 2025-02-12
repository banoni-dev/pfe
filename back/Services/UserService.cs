using back.Models;
using back.Repositories;
using System;
using System.Collections.Generic;

namespace back.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public UserModel GetUserById(int id)
        {
            return _userRepository.GetUserById(id);
        }

        public UserModel GetUserByEmail(string email)
        {
            return _userRepository.GetUserByEmail(email);
        }

        public List<UserModel> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }

        public UserModel CreateUser(UserModel user)
        {
            if (_userRepository.GetUserByEmail(user.Email) != null)
                throw new Exception("Email already exists");

            return _userRepository.CreateUser(user);
        }

        public UserModel UpdateUser(int id, UserModel updatedUser)
        {
            return _userRepository.UpdateUser(id, updatedUser);
        }

        public void DeleteUser(int id)
        {
            _userRepository.DeleteUser(id);
        }
    }
}
