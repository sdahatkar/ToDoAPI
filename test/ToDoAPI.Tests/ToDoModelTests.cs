using ToDoAPI.Models;

namespace ToDoAPI.Tests;

public class ToDoModelTests
{
    [Fact]
    public void CanChangeName()
    {
        var testToDo = new ToDoItem
        {
            Name = "Complete unit tests"
        };

        testToDo.Name = "Complete Azure Pipeline";

        Assert.Equal("Complete Azure Pipe", testToDo.Name);
    }
}