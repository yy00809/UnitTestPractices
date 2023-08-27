namespace TestNinja.NunitTests;
using TestNinja.Fundamentals;




public class StackTests
{
    [Test]
    public void Push_ArgIsNull_ThrowsArgumentNullException()
    {
        var stack = new Stack<string>();

  

        Assert.That(() => stack.Push(null!), Throws.Exception.TypeOf<ArgumentNullException>());
    }

    [Test]
    public void Push_AddNotNullObejct_CountIncreasedByOne() 
    {
        var stack = new Stack<int>();

        stack.Push(1);
        var count = stack.Count;

        Assert.That(count, Is.EqualTo(1));
    }

    [Test]
    public void Pop_WhenStackIsEmpty_ThrowInvalidOperationException() 
    {
        var stack = new Stack<int>();

        Assert.That(() => stack.Pop(), Throws.Exception.TypeOf<InvalidOperationException>());
    }

    [Test]
    public void Pop_WhenCalled_ReturnTheRecentAddedItemAndRemoveItFromStack()
    {
        var stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);
        Assert.Multiple(() =>
        {
            Assert.That(stack.Pop(), Is.EqualTo(4));
            Assert.That(stack.Count, Is.EqualTo(3));
        });
    }

    [Test]
    public void Peek_WhenStackIsEmpty_ThrowsInvalidOperationException()
    {
        var stack = new Stack<int>();

        Assert.That(() => stack.Peek(), Throws.Exception.TypeOf<InvalidOperationException>());
    }

    [Test]
    public void Peek_WhenCalled_ReturnTheRecentAddedItemAndStackIsTheSame()
    {
        var stack = new Stack<int>();

        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        Assert.Multiple(() =>
        {
            Assert.That(stack.Peek(), Is.EqualTo(3));
            Assert.That(stack.Count, Is.EqualTo(3));
        });
    }
}
