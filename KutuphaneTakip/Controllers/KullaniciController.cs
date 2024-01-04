using KutuphaneTakip.Models;
using KutuphaneTakip.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data;

namespace KutuphaneTakip.Controllers
{
    [Route("api/kullanicis")]
    [ApiController]
    public class KullaniciController : ControllerBase
    {
        private readonly RepositoryContext _context;
        public KullaniciController(RepositoryContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetAllKullanicis()
        {
            try
            {
                var kullanicis = _context.Kullanicis.ToList();
                return Ok(kullanicis);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }


    }
}
