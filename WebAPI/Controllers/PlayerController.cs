using Game.Data;
using Game.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Game.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly IPlayerService playerService;

        public PlayerController(IPlayerService playerService)
        {
            this.playerService = playerService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Player>> GetAll()
        {
            return Ok(playerService.GetAll());


        }

        [HttpPost]

        public ActionResult Insert([FromBody] Player player)
        {
            playerService.Insert(player);
            return Ok();

        }

    }
}
