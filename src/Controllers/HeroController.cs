using Microsoft.AspNetCore.Mvc;
using src.Dto;

namespace src.Controllers
{
  [ApiController]
  [Route("api/v1/heros")]
  public class HeroController
  {
      [HttpPost]
    public CreateHero Create(CreateHero hero)
    {
      return hero;
    }

  }
}