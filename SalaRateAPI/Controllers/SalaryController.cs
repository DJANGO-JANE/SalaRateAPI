using ApplicationLayer.DTO;
using AutoMapper;
using InfrastructureLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalaRateAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SalaryController : Controller
    {
        public readonly ISalary _service;
        public readonly IMapper _mapper;

        public SalaryController(ISalary salary, IMapper mapper)
        {
            _service = salary;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("Get-Gross")]
        public async Task<ActionResult<SalaryGross>> GetGrossSalary([FromQuery(Name = "amount")] float basic,
            [FromQuery(Name = "allowances")] float allowances)
        {
            var salary = await _service.GET_GROSS_SALARY(basic, allowances);


            return Ok(_mapper.Map<SalaryGross>(salary));
        }

        [HttpGet]
        [Route("Get-Net")]
        public async Task<ActionResult<SalaryNet>> GetNetSalary([FromQuery(Name = "amount")] float basic)
        {
            var salary = await _service.GET_NET_SALARY(basic);
            var result = _mapper.Map<SalaryNet>(salary);

            return Ok(result);
        }

   
    }
}
