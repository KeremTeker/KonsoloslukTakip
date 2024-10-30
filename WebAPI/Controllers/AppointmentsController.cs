using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntitiyFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentsController : ControllerBase
    {

        //Loosely coupled yani bir bağımlılığı var ama soyuta bağlı (gevşek bağlılık)
        //dependency injectionda ctor içindeki appointmentManager a zaten erişemeyiz fielda eşitleriz onu kullanırız. Bu desenin bir yönü de bu.
        //IOC Containerr -- Inversion of Control
        IAppointmentService _appointmentService;
        public AppointmentsController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }

        //hangi get i çalıştıracağını anlasın diye isimlendiriyoruz. ID de verebilirdik. Bunu adrese ekleyerek test edicez.
        [HttpGet("getall")]
        //public List<Appointment> Get()
        //http statü kodları için buna çevirdik.
        public IActionResult GetAll()
        {
            //AppointmentManager bizden hep bir Ef istiyor
            //sadece datayı istiryoruz mesaj ve success de döndürebilirdik.
            //Dependecy Chain -- IAppointmentService --> AppointmentManager --> EfAppointmentDal
            //IAppointmentService appointmentService = new AppointmentManager(new EfAppointmentDal());
            //var result = appointmentService.GetAll();
            //apide hiç bir business veya dal somut sınıfımız yok.

            //böyle yaptığımızda bağımsız oluyor ama controllerın genede somut bir referansa ihtiyacı var çünkü hangi IAppointmentService olduğunu bilemez.
            //bu durumda IOC Container a ihtiyacımız var.
            //referansları IOC Containerda ayrı olarak veririz. Api bizim yerimize gider verilen referanslara bakar.
            //buradaki result zaten IAppointmentService.GetAll. IDataResult dan success gelirse Ok http statü kodunu döndürecek.
            //Ok metodu bizden aynı zamanda bir value da istiyor. Orada da datayı döndürebiliriz(result.Data). Data mesaj gibi hepsini döndürmek istersek sadece result yazabiliriz.
            //http statü kodu sayesinde datanın gelmediği durumlarda neden gelmediği konusunu anlayabilmek için önemlidir. Null gelirse data gerçeklten mi null yoksa örneğin sistem bakımda mı bunları ayırt edebilmeyi sağlar.
            var result = _appointmentService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        //controller methodu ile içindeki dal methodu farklı method. Kolay olsun diye aynı ismi verdik. Normalde Get veya Post du.
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _appointmentService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        } 

        //if (result.Success) = if (result.Success==true)

        [HttpPost("add")]
        public IActionResult Add(Appointment appointment)
        {
            var result = _appointmentService.Add(appointment);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }   
    }
}