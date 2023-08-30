namespace Lab5.Tests;

public class MagazineTest
{
    [Fact]
    public void RemoveCartridgeFromEmptyMagazine()
    {
        //Arrange
        var magazine = new Magazine(0);
        //Act + Assert
        Assert.Null(magazine.GetCartridge());
    }

    [Fact]
    public void RemoveCartridgeFromNotEmptyMagazine()
    {
        //Arrange
        var magazine = new Magazine(10);
        //Act
        magazine.GetCartridge();
        //Assert
        Assert.Equal(9, magazine.Count());
    }

    [Fact]
    public void AddCartridgeInEmptyMagazine()
    {
        //Arrange
        var magazine = new Magazine(0);
        //Act
        magazine.AddCartridge(new Cartridge(false));
        //Assert
        Assert.Equal(1, magazine.Count());
    }

    [Fact]
    public void AddCartridgeInFullMagazine()
    {
        //Arrange
        var magazine = new Magazine(30);
        //Act + Assert
        Assert.Throws<InvalidOperationException>
            (() => magazine.AddCartridge(new Cartridge(false)));
    }

    [Fact]
    public void AddSleeveInMagazine()
    {
        //Arrange
        var magazine = new Magazine(20);
        //Act + Assert
        Assert.Throws<InvalidOperationException>
            (() => magazine.AddCartridge(new Cartridge(true)));
    }
    [Fact]
    public void MakeMagazineOverfull()
    {
        //Act + Assert
        Assert.Throws<InvalidOperationException>
            (() => new Magazine(31));
    }
    [Fact]
    public void MakeMagazineNegativeCartridgeCount()
    {
        //Act + Assert
        Assert.Throws<ArgumentOutOfRangeException>
            (() => new Magazine(-1));
    }
}