using FinalProjectPRN231.API.DTO.Common;
using FinalProjectPRN231.API.Infra.Constants;
using FinalProjectPRN231.API.Infra.Helps;
using Microsoft.AspNetCore.Mvc;

namespace FinalProjectPRN231.API.Controllers
{
    [Route(RouteApiConstant.BASE_PATH + "/test")]
    public class TestController : BaseAPIController
    {
        public TestController()
        {
            
        }
        [HttpGet]
        public ActionResult Index()
        {
            string key = "taodeptraivailon";
            string plainText = "EmpToken";
            var result = AesCrypto.EncryptString(plainText, key);
            var result2 = AesCrypto.DecryptString(result, key);
            //daylachuoikhoabi
            //taodeptraivailon
            //"u3CIq1pbGeAd7r9Byu1uAA=="

            return Ok(UserHeader);
        }
        [HttpGet("/cac")]
        public ActionResult GetTesttttttttt()
        {
            return Ok(new ResponseDTO<bool>((int)RESPONSE_CODE.OK, "cac"));
        }

    }
    
}
