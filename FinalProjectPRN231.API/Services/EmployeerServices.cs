using AutoMapper;
using FinalProjectPRN231.API.DTO.Common;
using FinalProjectPRN231.API.DTO.EmployeerDTO;
using FinalProjectPRN231.API.Infra.Data;
using FinalProjectPRN231.CoreBusiness.Entities;
using Microsoft.EntityFrameworkCore;

namespace FinalProjectPRN231.API.Services
{
    public interface IEmployeerServices
    {
        Task<ResponseDTO<PagedResultDTO<EmployeerDTO>>> GetEmployeers(ListEmployeerRequestDTO request);
        Task<ResponseDTO<bool>> AddOrEditEmployeer(EmployeerDTO employeerDTO);
        Task<ResponseDTO<bool>> DeleteEmployeer(int id);
    }
    public class EmployeerServices : IEmployeerServices
    {
        private readonly ILogger<EmployeerServices> _logger;
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public EmployeerServices(ILogger<EmployeerServices> logger, ApplicationDbContext context, IMapper mapper)
        {
            _logger = logger;
            _context = context;
            _mapper = mapper;
        }
        public async Task<ResponseDTO<bool>> AddOrEditEmployeer(EmployeerDTO employeerDTO)
        {
            if (employeerDTO == null) return new ResponseDTO<bool>((int)RESPONSE_CODE.BadRequest, @"Employeer Null");
            if (employeerDTO.Id < 0) return new ResponseDTO<bool>((int)RESPONSE_CODE.BadRequest, @"Employerr Not Exist");
            var entry = await _context.Employers.FirstOrDefaultAsync(e => e.Id == employeerDTO.Id && !employeerDTO.IsDeleted);
            if (entry != null)
            {
                entry.FullName = employeerDTO.FullName;
                entry.Gender = employeerDTO.Gender;
                entry.Email = employeerDTO.Email;
                entry.PhoneNumber = employeerDTO.PhoneNumber;
                entry.Description = employeerDTO.Description;
                entry.CivilId = employeerDTO.CivilId;
                entry.AvatarUrl = employeerDTO.AvatarUrl;
                entry.HiredDate = employeerDTO.HiredDate;
                entry.TerminationDate = employeerDTO.TerminationDate;
                _context.Update(entry);
            }
            else
            {
                var dataMapped = _mapper.Map<Employeer>(employeerDTO);
                await _context.AddAsync(dataMapped);
            }
            await _context.SaveChangesAsync();
            return new ResponseDTO<bool>(true);
        }

        public async Task<ResponseDTO<bool>> DeleteEmployeer(int id)
        {
            if (id < 0) return new ResponseDTO<bool>((int)RESPONSE_CODE.BadRequest, @"Employerr Not Exist");
            var entry = await _context.Employers.FirstOrDefaultAsync(e => e.Id == id);
            if (entry == null)
            {
                return new ResponseDTO<bool>((int)RESPONSE_CODE.NotFound, "Not Found");
            }
            entry.IsDeleted = true;
            _context.Update(entry);
            await _context.SaveChangesAsync();
            return new ResponseDTO<bool>(true);
        }

        public async Task<ResponseDTO<PagedResultDTO<EmployeerDTO>>> GetEmployeers(ListEmployeerRequestDTO request)
        {
            PagedResultDTO<EmployeerDTO> pagedResult;
            var data = await _context.Employers.AsQueryable().Where(e => !e.IsDeleted).ToListAsync();
            var count = data.Count();
            var result = data.Skip((request.PageIndex - 1) * request.PageSize).Take(request.PageSize).ToList();
            var dataMapped = _mapper.Map<List<EmployeerDTO>>(result);
            pagedResult = new PagedResultDTO<EmployeerDTO>(request.PageIndex, request.PageSize, count, dataMapped, 0);
            return new ResponseDTO<PagedResultDTO<EmployeerDTO>>(pagedResult);
        }
    }
}
