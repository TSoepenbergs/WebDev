using Microsoft.AspNetCore.Mvc;
using Setup.Models;

namespace Setup.Controllers
{
    public class GameController : Controller
    {
        public IActionResult Index()
        {
            Game myGame = new Game(1, new List<Person>(new[]
        {
            new Person("Thijs", 1),
            new Person("JESSE", 2),
        }));
            GameViewModel gameViewModel = new GameViewModel(myGame);
            return View(gameViewModel);
        }

        [HttpPost]
        public IActionResult NextQuestion(GameViewModel gvm)
        {
            gvm.game.nextQuestion();
            return View(gvm);
        }
    }
}
