using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TicTacToe.Lib;

namespace TicTacToe.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GameController : ControllerBase
{
    private static Game _game = new Game();

    [HttpGet("")]
    [ProducesResponseType(200)]
    public IActionResult GetBoard()
    {
        var b = new {
            pos1 = _game.Board[1],
            pos2 = _game.Board[2],
            pos3 = _game.Board[3],
            pos4 = _game.Board[4],
            pos5 = _game.Board[5],
            pos6 = _game.Board[6],
            pos7 = _game.Board[7],
            pos8 = _game.Board[8],
            pos9 = _game.Board[9]
        };
        return Ok(b);
    }

    [HttpPost("move/{pos}")]
    [ProducesResponseType(200)]
    [ProducesResponseType(400)]
    [ProducesResponseType(409)]
    public IActionResult MakeMove(int pos)
    {
        if (pos < 1 || pos > 9) {
            return BadRequest();
        }
        bool b = _game.MakeMove(pos);
        if (!b) return Conflict("The space is taken");

        return NoContent();
    }
}
