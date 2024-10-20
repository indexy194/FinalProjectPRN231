using FinalProjectPRN231.API.DTO.Configurations;

namespace FinalProjectPRN231.API.Infra.Constants
{
    public class StaticVariable
    {
        public static KeyHeaderToken KeyHeaderToken = ApiSettings.Get<KeyHeaderToken>("KeyHeaderToken");
    }
}
