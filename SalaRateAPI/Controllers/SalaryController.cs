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

        public SalaryController(ISalary salary)
        {
            _service = salary;
        }

        [HttpGet]
        [Route("Get-Gross")]
        public string GetGrossSalary([FromQuery(Name = "amount")] float basic)
        {
            var temp = _service.GET_GROSS_SALARY(basic);


            return "$"+temp;
        }

        [HttpGet]
        [Route("Get-Net")]
        public string GetNetSalary([FromQuery(Name = "amount")] float basic)
        {
            var temp = _service.GET_NET_SALARY(basic);


            return "$" + temp;
        }

        [HttpGet]
        [Route("Get-EPA")]
        public string GetEmployeePensionAmount([FromQuery(Name = "amount")] float basic)
        {
            var temp = _service.EMPLOYEE_PENSION_AMOUNT(basic);


            return "$" + temp;
        }

        //[HttpGet]
        //[Route("Get-EPCA")]
        //public float GetEmployeePensionContributionAmount([FromQuery(Name = "amount")] float basic)
        //{
        //    var temp = _service.EMPLOYEE_PENSION_AMOUNT(basic);


        //    return temp;
        //}
    }
}
