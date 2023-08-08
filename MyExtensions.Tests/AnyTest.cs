using Xunit;
namespace MyExtensions.Tests;

public class AnyTest
{
    [Fact]
    public void TestNullCollectionWithPredicate()
    {
        //Arrange
        IList<int>? list = null;
        //Act + assert
        Assert.Throws<InvalidOperationException>(() => list.Any(a => a % 2 == 0));
    }
    [Fact]
    public void TestNullCollectionWithoutPredicate()
    {
        //Arrange
        IList<int>? list = null;
        //Act + assert
        Assert.Throws<InvalidOperationException>(() => list.Any());
    }
    [Fact]
    public void TestNullCollectionWithNullPredicate()
    {
        //Arrange
        IList<int>? list = null;
        //Act + assert
        Assert.Throws<InvalidOperationException>(() => list.Any(null));
    }
    
    /////
    
    [Fact]
    public void TestEmptyCollectionWithPredicate()
    {
        //Arrange
        IList<int> list = new List<int>();
        //Act + assert
        Assert.False(list.Any(a => a % 2 == 0));
    }
    [Fact]
    public void TestEmptyCollectionWithoutPredicate()
    {
        //Arrange
        IList<int> list = new List<int>();
        //Act + assert
        Assert.False(list.Any());
    }
    [Fact]
    public void TestEmptyCollectionWithNullPredicate()
    {
        //Arrange
        IList<int> list = new List<int>();
        //Act + assert
        Assert.False(list.Any(null));
    }
    
    /////////////
    
    [Fact]
    public void TestCollectionWithTruePredicate()
    {
        //Arrange
        IList<int> list = new List<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);
        //Act + assert
        Assert.True(list.Any(a => a % 2 == 0));
    }
    [Fact]
    public void TestCollectionWithFalsePredicate()
    {
        //Arrange
        IList<int> list = new List<int>();
        list.Add(1);
        list.Add(3);
        list.Add(5);
        list.Add(7);
        //Act + assert
        Assert.False(list.Any(a => a % 2 == 0));
    }
    [Fact]
    public void TestCollectionWithoutPredicate()
    {
        //Arrange
        IList<int> list = new List<int>();
        list.Add(1);
        list.Add(3);
        list.Add(5);
        list.Add(7);
        //Act + assert
        Assert.True(list.Any());
    }
    [Fact]
    public void TestCollectionWithNullPredicate()
    {
        //Arrange
        IList<int> list = new List<int>();
        list.Add(1);
        list.Add(3);
        list.Add(5);
        list.Add(7);
        //Act + assert
        Assert.True(list.Any(null));
    }
}