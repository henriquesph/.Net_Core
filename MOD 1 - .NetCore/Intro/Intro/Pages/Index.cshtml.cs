using Intro.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Intro.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private ApplicationDbContext _context;

        public IndexModel(ILogger<IndexModel> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public void OnGet()
        {
            _logger.LogInformation("Meu usuário acessou a página Index");
            var usuarios = _context.Users.ToList();
            // Console.WriteLine(usuarios[0].NormalizedUserName); usuário que cadastrei no BD

            _logger.LogWarning("cuidado");
        }
    }
}