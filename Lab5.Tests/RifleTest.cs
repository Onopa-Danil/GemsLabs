

namespace Lab5.Tests;

public class RifleTest
{
    [Fact]
    public void RechargingWithEmptyChamber()
    {
        //Arrange
        var magazine = new Magazine(1);
        var rifle = new Rifle(false, magazine);
        //Act + Assert
        Assert.False(rifle.Chamber);
        rifle.Recharge();
        Assert.True(rifle.Chamber);
    }
    [Fact]
    public void RechargingWithNotEmptyChamber()
    {
        //Arrange
        var magazine = new Magazine(2);
        var rifle = new Rifle(false, magazine);
        //Act
        rifle.Recharge();
        rifle.Recharge();
        //Assert
        Assert.False(rifle.Chamber);
    }
    [Fact]
    public void RechargingWithFuseOn()
    {
        //Arrange
        var magazine = new Magazine(2);
        var rifle = new Rifle(true, magazine);
        //Act + Assert
        Assert.Throws<InvalidOperationException>(() => rifle.Recharge());

    }

    [Fact]
    public void FireWithTheFuseOnAndFullMagazine()
    {
        //Arrange
        var magazine = new Magazine(30);
        var rifle = new Rifle(true, magazine);
        //Act + Assert
        Assert.Null(rifle.Fire());
    }
    [Fact]
    public void FireWithTheFuseOffAndFullMagazineWithEmptyChamber()
    {
        //Arrange
        var magazine = new Magazine(30);
        var rifle = new Rifle(false, magazine);
        //Act + Assert
        Assert.False(rifle.Chamber);
        Assert.Null(rifle.Fire());
    }
    [Fact]
    public void FireWithTheFuseOffAndFullMagazineWithNotEmptyChamber()
    {
        //Arrange
        var magazine = new Magazine(30);
        Cartridge? cartridge = magazine.GetCartridge();
        magazine.AddCartridge(cartridge);
        
        var rifle = new Rifle(false, magazine);
        //Act + Assert
        Assert.False(rifle.Chamber);
        rifle.Recharge();
        Assert.Same(cartridge, rifle.Fire());
        Assert.False(rifle.Chamber);
    }
    
    [Fact]
    public void RechargeWithEmptyMagazineAndFullChamber()
    {
        //Arrange
        var magazine = new Magazine(1);
        var rifle = new Rifle(false, magazine);
        //Act + Assert
        Assert.False(rifle.Chamber);
        rifle.Recharge();
        rifle.Recharge();
        Assert.False(rifle.Chamber);
    }
    
    [Fact]
    public void RechargeWithEmptyMagazineAndEmptyChamber()
    {
        //Arrange
        var magazine = new Magazine(0);
        var rifle = new Rifle(false, magazine);
        //Act + Assert
        Assert.False(rifle.Chamber);
        Assert.Throws<InvalidOperationException>(() => rifle.Recharge());
    }

    [Fact]
    public void FireWithEmptyMagazineEmptyChamberOffFuse()
    {
        //Arrange
        var magazine = new Magazine(0);
        var rifle = new Rifle(false, magazine);
        //Act + Assert
        Assert.False(rifle.Chamber);
        Assert.Null(rifle.Fire());
    }
    
 
}