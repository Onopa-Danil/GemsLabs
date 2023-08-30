namespace Lab5.Tests;

public class CartridgeTest
{
    [Fact]
    public void TestOfUsedCartridge()
    {
        //Arrange
        var cartridge = new Cartridge(true);
        //Act + Assert
        Assert.Throws<InvalidOperationException>(() => cartridge.Use());
    }
    [Fact]
    public void TestOfNotUsedCartridge()
    {
        //Arrange
        var cartridge = new Cartridge(false);
        //Act
        cartridge.Use();
        //Assert
        Assert.True(cartridge.Used);
    }
}