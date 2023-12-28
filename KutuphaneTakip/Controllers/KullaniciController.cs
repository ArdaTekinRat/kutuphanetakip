using KutuphaneTakip.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KutuphaneTakip.Controllers
{
    [Route("api/kullanicis")]
    [ApiController]
    public class KullaniciController : ControllerBase
    {
        private readonly ILogger<KullaniciController> _logger;
        public KullaniciController(ILogger<KullaniciController> logger) {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult GettAllKullanicis()
        {
            var kullanici = new List<Kullanici>()
            {
                new Kullanici() {Id=1,AdresId=1,Gmail="master@gmail.com",Telefon=053503744,Erisebilirlik=1},
                new Kullanici() {Id=2,AdresId=2,Gmail="asmon@gmail.com",Telefon=2342432,Erisebilirlik=2},
                
            };
           
            return Ok(kullanici);

        }

    }
}
