using Xunit;
namespace MyExtensions.Tests;

public class WhereTest
{
    [Fact]
    public void TestCollectionWithTruePredicate()
    {
        //Arrange
        IList<int> list = new List<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);
        IList<int> resultList = new List<int>();
        resultList.Add(2);
        resultList.Add(4);
        //Act + assert
        Assert.Equal(resultList, list.Where(a => a % 2 == 0));
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
        IList<int> resultList = new List<int>();
        //Act + assert
        Assert.Equal(resultList, list.Where(a => a % 2 == 0));
    }
    [Fact]
    public void TestEmptyCollectionWithPredicate()
    {
        //Arrange
        IList<int> list = new List<int>();
        IList<int> resultList = new List<int>();
        //Act + assert
        Assert.Equal(resultList, list.Where(a => a % 2 == 0));
    }
    [Fact]
    public void TestNullCollectionWithPredicate()
    {
        //Arrange
        IList<int>? list = null;
        IList<int> resultList = new List<int>();
        //Act + assert
        Assert.Equal(resultList, list.Where(a => a % 2 == 0));
    }
    
    
    
    [Fact]
    public void TestCollectionWithNullPredicate()
    {
        //Arrange
        IList<int> list = new List<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);
        //Act + assert
        Assert.Throws<InvalidOperationException>(() => list.Where(null));
    }
    
    [Fact]
    public void TestEmptyCollectionWithNullPredicate()
    {
        //Arrange
        IList<int> list = new List<int>();
        //Act + assert
        Assert.Throws<InvalidOperationException>(() => list.Where(null));
    }
    [Fact]
    public void TestNullCollectionWithNullPredicate()
    {
        //Arrange
        IList<int>? list = null;
        //Act + assert
        Assert.Throws<InvalidOperationException>(() => list.Where(null));
    }
}