namespace ChoreScore.Models;
public class Chore(System.Guid? id, string name, byte hours, bool isComplete)
{
    public System.Guid? Id { get; set; } = id;
    public string Name { get; set; } = name;
    public byte Hours { get; set; } = hours;
    public bool IsComplete { get; set; } = isComplete;
}