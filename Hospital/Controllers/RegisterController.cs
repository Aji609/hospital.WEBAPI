using Hospital.Data;
using Hospital.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        HospitalDbContext hospital;
        private readonly ILogger<RegisterController> logger;
        public RegisterController(HospitalDbContext hospital, ILogger<RegisterController> logger)
        {
            this.hospital = hospital;
            this.logger = logger;
        }
        [HttpGet]
        public IActionResult GetDetails()
        {
            logger.LogInformation("post");
            try
            {
                int a = 10;
                int b = a / 0;

            }
            catch(Exception ex) 
            {
                logger.LogError("ex");
            }
            List<Register> lst= hospital.Registeres.ToList();
                return Ok(lst);
        }
        [HttpPost]
        public IActionResult SaveData(Register register)
        {
            Register reg = new Register();
            reg.Id = register.Id;
            reg.Name = register.Name;
            reg.Address = register.Address;
            reg.Payment = register.Payment;
            hospital.Add(reg);
            hospital.SaveChanges();
            return Ok(reg);
        }
    }
}
