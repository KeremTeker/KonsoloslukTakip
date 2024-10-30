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

        [HttpGet]
        public List<Appointment> Get()
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
            var result = _appointmentService.GetAll();
            return result.Data;
            
        }
    }
}
