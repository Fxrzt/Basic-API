using Microsoft.AspNetCore.Mvc;
using WebTestApi.Models;

namespace WebTestApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet]
        // method is Get can change anything
        public IEnumerable<UserModel> Get () 
        {
            List<UserModel> list = new List<UserModel>();
            list.Add(new UserModel
            {
                Id = 1,
                Name = "User1",
                Age = 11
            });
            list.Add(new UserModel
            {
                Id = 2,
                Name = "User2",
                Age = 22
            });
            list.Add(new UserModel
            {
                Id = 3,
                Name = "User3",
                Age = 33
            });
            return list;
        }
        [HttpGet("{id}")]
        public UserModel Deleted (int id)
        {
            return new UserModel {
                Id = id,
                Name = "User1",
                Age = 20
            };
        }
        [HttpDelete("{id}")]
        public UserModel Get (int id)
        {
            return new UserModel
            {
                Id = id,
                Name = "Deleted",
                Age = 45
            };
        }
        [HttpPost]
        // input is UserModel
        public UserModel Create (UserModel data)
        {
            data.Name += "Created";
            return data;
        }
        [HttpPut]
        // input is UserModel
        public UserModel Updated (UserModel data)
        {
            data.Name += "Updated";
            return data;
        }
    }
}