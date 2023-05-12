using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1Prova.Database;
using WebApplication1Prova.Model.Request;

namespace WebApplication1Prova.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private  static FakeDatabase database = new FakeDatabase();

        [HttpGet]
        public IActionResult GetUser(int idUser)
        {
            var user = database.Users.FirstOrDefault(x =>x.IdUser== idUser);

            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [HttpGet("all")]
        public IActionResult AllUser() 
        {
            return Ok(database.Users);
        }

        [HttpDelete]
        public IActionResult DeleteUser(int IdUser)
        {
            var user = database.Users.FirstOrDefault(x => x.IdUser == IdUser);
            if (user == null)
            {
                return NotFound();
            }
            database.Users.Remove(user);
            return Ok();
        }

        [HttpPost("post")]
        public IActionResult AddUser([FromBody] AddUserRequest user)
        {
            database.AddUser(new Database.User
            { IdUser = 0, Name = user.Name, Password = user.Password, Surname = user.Surname, userName = user.userName });
            return Ok();
        }
    }
}
