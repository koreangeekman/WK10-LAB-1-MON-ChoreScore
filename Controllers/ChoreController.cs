namespace ChoreScore.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ChoreController(ChoreService choreService) : ControllerBase
{
    [HttpGet]
    public ActionResult<List<Chore>> GetChores()
    {
        try
        {
            List<Chore> chores = choreService.GetChores();
            return Ok(chores);
        }
        catch (Exception e) { return BadRequest(e.Message); }
    }

    [HttpGet("{choreId}")]
    public ActionResult<Chore> GetChoreById(Guid choreId)
    {
        try
        {
            Chore chore = choreService.GetChoreById(choreId);
            return Ok(chore);
        }
        catch (Exception e) { return BadRequest(e.Message); }
    }

    [HttpPost]
    public ActionResult<Chore> CreateChore([FromBody] Chore choreData)
    {
        try
        {
            Chore chore = choreService.CreateChore(choreData);
            return Ok(chore);
        }
        catch (Exception e) { return BadRequest(e.Message); }
    }

    [HttpDelete("{choreId}")]
    public ActionResult<string> DeleteChore(Guid choreId)
    {
        try
        {
            string result = choreService.DeleteChore(choreId);
            return Ok(result);
        }
        catch (Exception e) { return BadRequest(e.Message); }
    }

}