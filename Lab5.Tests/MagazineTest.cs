using MyUnit;
using MyUnit.Attributes;

namespace Lab5.Tests;

public class MagazineTest
{
    [MyFact]
    public void RemoveCartridgeFromEmptyMagazine()
    {
        //Arrange
        var magazine = new Magazine(0);
        //Act + Assert
        MyAssert.Null(magazine.GetCartridge());
    }

    [MyFact]
    public void RemoveCartridgeFromNotEmptyMagazine()
    {
        //Arrange
        var magazine = new Magazine(10);
        //Act
        magazine.GetCartridge();
        //Assert
        MyAssert.Equal(9, magazine.Count());
    }

    [MyFact]
    public void AddCartridgeInEmptyMagazine()
    {
        //Arrange
        var magazine = new Magazine(0);
        //Act
        magazine.AddCartridge(new Cartridge(false));
        //Assert
        MyAssert.Equal(1, magazine.Count());
    }

    [MyFact]
    public void AddCartridgeInFullMagazine()
    {
        //Arrange
        var magazine = new Magazine(30);
        //Act + Assert
        MyAssert.Throws<InvalidOperationException>
            (() => magazine.AddCartridge(new Cartridge(false)));
    }

    [MyFact]
    public void AddSleeveInMagazine()
    {
        //Arrange
        var magazine = new Magazine(20);
        //Act + Assert
        MyAssert.Throws<InvalidOperationException>
            (() => magazine.AddCartridge(new Cartridge(true)));
    }
    [MyFact]
    public void MakeMagazineOverfull()
    {
        //Act + Assert
        MyAssert.Throws<InvalidOperationException>
            (() => new Magazine(31));
    }
    [MyFact]
    public void MakeMagazineNegativeCartridgeCount()
    {
        //Act + Assert
        MyAssert.Throws<ArgumentOutOfRangeException>
            (() => new Magazine(-1));
    }
}