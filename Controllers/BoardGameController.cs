using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BoardGameCollectionAPI.Controllers
{
    [Route("api/[controller]")]
    public class BoardGameController : Controller
    {
        private static List<BoardGame> games = new List<BoardGame>
        {
            new BoardGame { Id = 1, 
                            Title = "Risk", 
                            Description = "Risk is a strategy board game of diplomacy, conflict and conquest for two to six players.",
                            Category = "Strategy",
                            Publisher = "Hasbro"
                            }
        };

        [HttpGet]
        public async Task<IActionResult> Get() 
        {
            return Ok(games);
        }

         [HttpPost]
        public async Task<IActionResult> AddBoardGame(BoardGame boardGame) 
        {
            games.Add(boardGame);
            return Ok(games);
        }
    }
}