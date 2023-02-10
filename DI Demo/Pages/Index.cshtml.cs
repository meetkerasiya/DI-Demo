using DI_Demo.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DI_Demo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IPlayerGenerator _playerGenerator;
        public static Player newPlayer;

        public IndexModel(ILogger<IndexModel> logger,IPlayerGenerator playerGenerator)
        {
            _logger = logger;
            _playerGenerator = playerGenerator;
        }

        public void OnGet()
        {
            newPlayer=_playerGenerator.CreateNewPlayer();
           
        }
    }
}