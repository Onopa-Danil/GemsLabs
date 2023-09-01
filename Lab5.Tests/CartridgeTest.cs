using MyUnit;
using MyUnit.Attributes;

namespace Lab5.Tests;

public class CartridgeTest
{
    [MyFact]
    public void TestOfUsedCartridge()
    {
        //Arrange
        var cartridge = new Cartridge(true);
        //Act + Assert
        MyAssert.Throws<InvalidOperationException>(() => cartridge.Use());
    }
    [MyFact]
    public void TestOfNotUsedCartridge()
    {
        //Arrange
        var cartridge = new Cartridge(false);
        //Act
        cartridge.Use();
        //Assert
        MyAssert.True(cartridge.Used);
    }
}