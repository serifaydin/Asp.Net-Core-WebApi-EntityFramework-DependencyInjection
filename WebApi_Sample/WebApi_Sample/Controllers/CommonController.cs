using DataLibrary.Common.IdentityManagement;
using DataModels;
using Microsoft.AspNetCore.Mvc;

namespace MLTP.Services.ApiService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommonController : Controller
    {
        private ILoginUnitOfWork _loginUow;

        public CommonController(ILoginUnitOfWork loginUow)
        {
            _loginUow = loginUow;
        }

        [HttpGet]
        [Route("Login/{username}/{password}")]

        public ResponseItem Login(string username, string password)
        {
            ResponseItem result = new ResponseItem();
            result.Result = true;

            try
            {
                result.Data = _loginUow.Authenticate(username, password);
                result.Message = "success";
            }
            catch (System.Exception ex)
            {
                result.Result = false;
                result.Message = ex.Message;
            }

            return result;
        }
    }
}