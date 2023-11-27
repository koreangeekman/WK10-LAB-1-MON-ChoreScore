namespace ChoreScore.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ChoreController(ChoreService choreService) : ControllerBase
{
}