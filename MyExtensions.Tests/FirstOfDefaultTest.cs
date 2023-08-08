using Xunit;
namespace MyExtensions.Tests;

public class FirstOfDefaultTest
{
    [Fact]
    public void TestOfGetFirstElemWithTruePredicate()
    {
        //Arrange
        IList<int> list = new List<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        //Act
        int res = list.FirstOrDefault(a => a % 2 == 0);
        //Assert
        Assert.Equal(2, res);
    }
    [Fact]
    public void TestOfGetFirstElemWithFalsePredicate()
    {
        //Arrange
        IList<int> list = new List<int>();
        list.Add(1);
        list.Add(3);
        //Act
        int res = list.FirstOrDefault(a => a % 2 == 0);
        //Assert
        Assert.Equal(0, res);
    }

    [Fact]
    public void TestEmptyCollectionWithNotNullPredicate()
    {
        //Arrange
        IList<int> list = new List<int>();
        //Act + assert
        Assert.Equal(0, list.FirstOrDefault(a => a % 2 == 0));
    }
    [Fact]
    public void TestEmptyCollectionWithNullPredicate()
    {
        //Arrange
        IList<int> list = new List<int>();
        //Act + assert
        Assert.Equal(0, list.FirstOrDefault(null));
    }
    [Fact]
    public void TestNullCollectionWithNotNullPredicate()
    {
        //Arrange
        IList<int>? list = null;
        //Act + assert
        Assert.Equal(0 ,list.FirstOrDefault(a => a % 2 == 0));
    }
    [Fact]
    public void TestNullCollectionWithNullPredicate()
    {
        //Arrange
        IList<int>? list = null;
        //Act + assert
        Assert.Equal(0 ,list.FirstOrDefault(null));
    }
    [Fact]
    public void TestEmptyCollectionWithoutPredicate()
    {
        //Arrange
        IList<int> list = new List<int>();
        //Act + assert
        Assert.Equal(0 ,list.FirstOrDefault());
    }
    [Fact]
    public void TestNullCollectionWithoutPredicate()
    {
        //Arrange
        IList<int>? list = null;
        //Act + assert
        Assert.Equal(0 ,list.FirstOrDefault());
    }
    [Fact]
    public void TestCollectionWithoutPredicate()
    {
        //Arrange
        IList<int> list = new List<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        //Act
        int res = list.FirstOrDefault();
        //Assert
        Assert.Equal(1, res);
    }

    [Fact]
    public void TestCollectionWithNullPredicate()
    {
        //Arrange
        IList<int> list = new List<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        //Act
        int res = list.FirstOrDefault(null);
        //Assert
        Assert.Equal(1, res);
    }
}