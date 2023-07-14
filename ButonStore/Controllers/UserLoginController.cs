using Microsoft.AspNetCore.Mvc;
using ButonStore.DbEntityClasses;
using ButonStore.BusinessServices.Interface;
using ButonStore.BusinessServices.Services;

namespace ButonStore.Controllers
{
    [Route("[controller]")]
    public class UserLoginController : Controller
    {
        private readonly IUserLoginService _userLoginService;
        public UserLoginController(IUserLoginService userLoginService)
        {
            _userLoginService = userLoginService;
        }

        [HttpPost("AddUserAccountDetails")]
        public async Task<IActionResult> AddUserAccountDetails([FromBody] UserLoginDetail userLoginDetail)
        {
            try
            {
                _userLoginService.AddUserLoginDetails(userLoginDetail);
                return Ok();
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
    }
}
