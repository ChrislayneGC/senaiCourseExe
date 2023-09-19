
namespace Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : Controller
    {
        private readonly LivroController _livroRepository;

        public LivroController(LivroController livroRepository)
        {
            _livroRepository = livroRepository;
        }

        public IActionResult Listar()
        {
            try 
            {
                return Ok(_livroRepository.Listar())
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message)
            }
            
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}