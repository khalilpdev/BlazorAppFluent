namespace BlazorAppFluent.Shared.Models;

public class Todo
{
    public Guid Id { get; set; } = new Guid();
    public DateTime CreateDate { get; set; } = DateTime.Now;
    public DateTime? DueDate { get; set; }
    public string? Description { get; set; }
    public bool IsDone { get; set; }

    public override string ToString()
    {
        return $"{Description} (Due: {DueDate?.ToShortDateString() ?? "No due date"}, Done: {IsDone})";
    }

    public static IQueryable<Todo> GetFakeData()
    {
        var todos = new List<Todo>
        {
            new Todo { Id = Guid.NewGuid(), CreateDate = DateTime.Now.AddDays(-5), DueDate = DateTime.Now.AddDays(2), Description = "Buy groceries", IsDone = false },
            new Todo { Id = Guid.NewGuid(), CreateDate = DateTime.Now.AddDays(-3), DueDate = DateTime.Now.AddDays(1), Description = "Finish project report", IsDone = true },
            new Todo { Id = Guid.NewGuid(), CreateDate = DateTime.Now.AddDays(-1), DueDate = null, Description = "Call mom", IsDone = false },
            new Todo { Id = Guid.NewGuid(), CreateDate = DateTime.Now, DueDate = DateTime.Now.AddDays(7), Description = "Plan weekend trip", IsDone = false }
        };

        return todos.AsQueryable();
    }

}
