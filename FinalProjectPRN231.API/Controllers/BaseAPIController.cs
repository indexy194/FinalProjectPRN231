using FinalProjectPRN231.API.DTO.Users;
using FinalProjectPRN231.API.Infra.Constants;
using FinalProjectPRN231.API.Infra.Helps;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace FinalProjectPRN231.API.Controllers
{
    [ApiController]
    public class BaseAPIController : ControllerBase
    {
        public BaseAPIController()
        {

        }
        protected UserHeader UserHeader
        {
            get
            {
                try
                {
                    if (AccessToken == null) { return null; }
                    var tmp = AesCrypto.DecryptString(AccessToken, StaticVariable.KeyHeaderToken.SecretKey);
                    var user = JsonConvert.DeserializeObject<UserHeader>(tmp);
                    return user;
                }
                catch
                {
                    return null;
                }
            }
        }
        public string AccessToken
        {
            get
            {
                var header = HttpContext.Request.Headers;
                header.TryGetValue(StaticVariable.KeyHeaderToken.KeyHeader, out var token);
                return token;
            }
        }
    }
}
