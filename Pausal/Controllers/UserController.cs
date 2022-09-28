using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pausal.BLL.Interfaces;

namespace Pausal.WEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;
       

        public UserController(IUserService service)
        {          
            _service = service;
        }

        //[AllowAnonymous]
        //[HttpPost]
        //[Route("api/[controller]/register")]
        //public async Task<IActionResult> Registration([FromBody] UserModel user)
        //{
        //    var message = await _service.CreateUser(user);
        //    if (message != "OK")
        //        return BadRequest(message);
        //    return Ok(user);
        //}

        //[AllowAnonymous]
        //[HttpGet]
        //[Route("api/[controller]/getAll")]
        //public async Task<List<UserModel>> GetAll()
        //{

           
        //    return await _service.GetAll();
        //}
    }
}
