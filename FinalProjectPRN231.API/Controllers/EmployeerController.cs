using FinalProjectPRN231.API.DTO.Common;
using FinalProjectPRN231.API.DTO.EmployeerDTO;
using FinalProjectPRN231.API.Infra.Constants;
using FinalProjectPRN231.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace FinalProjectPRN231.API.Controllers
{
    [Route(RouteApiConstant.BASE_PATH + "/employeer")]
    public class EmployeerController : BaseAPIController
    {
        private readonly IEmployeerServices _employeerServices;

        public EmployeerController(IEmployeerServices employeerServices)
        {
            _employeerServices = employeerServices;
        }
        [HttpGet("list-employeers")]
        public async Task<ResponseDTO<PagedResultDTO<EmployeerDTO>>> GetEmployeers([FromQuery]ListEmployeerRequestDTO request)
        {
            var data = await _employeerServices.GetEmployeers(request);
            return data;
        }
        [HttpPost("add-employeer")]
        public async Task<ResponseDTO<bool>> AddEmployeer(EmployeerDTO model)
        {
            var data = await _employeerServices.AddOrEditEmployeer(model);
            return data;
        }
        [HttpPost("delete-employeer")]
        public async Task<ResponseDTO<bool>> DeleteEmployeer(int id)
        {
            var data = await _employeerServices.DeleteEmployeer(id);
            return data;
        }
    }
}
