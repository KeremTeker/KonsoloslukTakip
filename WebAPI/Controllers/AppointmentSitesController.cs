using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentSitesController : ControllerBase
    {
        IAppointmentSiteService _appointmentSiteService;
        public AppointmentSitesController(IAppointmentSiteService appointmentSiteService)
        {
            _appointmentSiteService = appointmentSiteService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _appointmentSiteService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(AppointmentSite appointmentSite)
        {
            var result = _appointmentSiteService.Add(appointmentSite);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
