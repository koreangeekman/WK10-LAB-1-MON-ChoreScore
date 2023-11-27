
namespace ChoreScore.Repositories;

public class ChoresRepo
{
  private readonly List<Chore> _chores;

  public ChoresRepo()
  {
    _chores = [
      new Chore(Guid.NewGuid(),"Mow Lawn",5,false),
      new Chore(Guid.NewGuid(),"Weed-eater",1,false),
      new Chore(Guid.NewGuid(),"Wash vehicles",2,false),
      new Chore(Guid.NewGuid(),"Clean tools/equipment/self",1,false)
    ];
  }

  internal List<Chore> GetChores()
  {
    return _chores;
  }

  internal Chore GetChoreById(Guid choreId)
  {
    Chore chore = _chores.Find(chore => chore.Id == choreId);
    return chore ?? throw new Exception($"Cannot find chore with ID: {choreId}");
  }

  internal Chore CreateChore(Chore choreData)
  {
    choreData.Id = Guid.NewGuid();
    _chores.Add(choreData);
    return choreData;
  }

  internal void DeleteChore(Chore chore)
  {
    _chores.Remove(chore);
  }

  internal Chore UpdateChore(Chore chore)
  {
    return chore;
  }
}