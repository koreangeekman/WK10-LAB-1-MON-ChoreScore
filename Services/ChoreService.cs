namespace ChoreScore.Services;

public class ChoreService(ChoresRepo choresRepo)
{
  internal List<Chore> GetChores()
  {
    List<Chore> chores = choresRepo.GetChores();
    return chores;
  }

  internal Chore GetChoreById(Guid choreId)
  {
    Chore chore = choresRepo.GetChoreById(choreId);
    return chore;
  }

  internal Chore CreateChore(Chore choreData)
  {
    if (choreData.Name == null)
    {
      throw new Exception("Provide a name for your chore");
    }
    Chore chore = choresRepo.CreateChore(choreData);
    return chore;
  }

  internal string DeleteChore(Guid choreId)
  {
    Chore chore = GetChoreById(choreId);
    choresRepo.DeleteChore(chore);
    return $"Chore '{chore.Name}' has been deleted";
  }

  internal Chore UpdateChore(Guid choreId, Chore choreData)
  {
    Chore chore = GetChoreById(choreId);
    // incomplete/non-functional
    chore.Name = choreData.Name;
    Chore updated = choresRepo.UpdateChore(chore);
    return updated;
  }
}