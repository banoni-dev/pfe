using Microsoft.AspNetCore.Mvc;
using back.Models;
using System.Collections.Generic;
using System.Linq;

namespace back.Controllers
{
    [ApiController]
    [Route("user")]
    public class UserController : ControllerBase
    {
        private static List<UserModel> users = new List<UserModel>();
        private static int nextId = 1;

        // GET /user/id/{id} → Retrieve a user by their ID
        [HttpGet("id/{id}")]
        public IActionResult GetUserById(int id)
        {
            var user = users.FirstOrDefault(u => u.Id == id);
            return user != null ? Ok(user) : NotFound(new { message = "User not found" });
        }

        // GET /user/email/{email} → Retrieve a user by their email
        [HttpGet("email/{email}")]
        public IActionResult GetUserByEmail(string email)
        {
            var user = users.FirstOrDefault(u => u.Email == email);
            return user != null ? Ok(user) : NotFound(new { message = "User not found" });
        }

        // GET /user/all → Retrieve all users
        [HttpGet("all")]
        public IActionResult GetAllUsers()
        {
            return Ok(new { users });
        }

        // POST /user → Create a new user
        [HttpPost]
        public IActionResult CreateUser([FromBody] UserModel user)
        {
            if (users.Any(u => u.Email == user.Email))
                return Conflict(new { message = "Email already exists" });

            user.Id = nextId++;
            users.Add(user);

            return CreatedAtAction(nameof(GetUserById), new { id = user.Id }, user);
        }

        // PUT /user/{id} → Update user details
        [HttpPut("{id}")]
        public IActionResult UpdateUser(int id, [FromBody] UserModel updatedUser)
        {
            var user = users.FirstOrDefault(u => u.Id == id);
            if (user == null)
                return NotFound(new { message = "User not found" });

            user.FirstName = updatedUser.FirstName;
            user.LastName = updatedUser.LastName;
            user.Email = updatedUser.Email;
            user.Telephone = updatedUser.Telephone;

            return Ok(user);
        }

        // DELETE /user/{id} → Delete a user
        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            var user = users.FirstOrDefault(u => u.Id == id);
            if (user == null)
                return NotFound(new { message = "User not found" });

            users.Remove(user);
            return NoContent();
        }
    }
}
