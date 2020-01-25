using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Games2020_1.Data;
using Games2020_1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Games2020_1.Controllers
{
    public class GameController : Controller
    {
        private GameContexDb _db;

        public GameController(GameContexDb db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Game> games = _db.Games
                     .Include(g=>g.Genre).ToList();
            return View(games);
        }
    }
}