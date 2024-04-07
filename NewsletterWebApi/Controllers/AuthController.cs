using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewsletterWebApi.Context;

namespace NewsletterWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly NewsletterDb _context;

        public AuthController(NewsletterDb context)
        {
            _context = context;
        }
    }
}
