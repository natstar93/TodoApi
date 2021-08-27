  // why doesn't this have to be in the TodoApi.Models namespace?
  public class TodoItemDTO
  {
    public long Id { get; set; }
    public string Name { get; set; }
    public bool IsComplete { get; set; }
  }
