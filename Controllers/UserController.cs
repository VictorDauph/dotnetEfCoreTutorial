using dotnetEFcoreDBFirstTutorial.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnetEFcoreDBFirstTutorial.Controllers
{
    
    [ApiController]
    [Route("UserRoute")]
    public class UserController :ControllerBase
    {
        
        private readonly DotnetEfcoreDbfirstTutorialContext _dbContext;

        public UserController(DotnetEfcoreDbfirstTutorialContext dbContext )
        {
            _dbContext = dbContext;
        }
        

        [HttpGet()]
        public IEnumerable<dynamic> getUsersRoutes()
        {
            Console.WriteLine("GetUser Called");
            return _dbContext.Users.ToList();
        }
    }

}

