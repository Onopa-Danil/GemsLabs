

using MyUnit;
using MyUnit.Attributes;

namespace Lab5.Tests;

public class RifleTest
{
    [MyFact]
    public void RechargingWithEmptyChamber()
    {
        //Arrange
        var magazine = new Magazine(1);
        var rifle = new Rifle(false, magazine);
        //Act + Assert
        MyAssert.False(rifle.Chamber);
        rifle.Recharge();
        MyAssert.True(rifle.Chamber);
    }
    [MyFact]
    public void RechargingWithNotEmptyChamber()
    {
        //Arrange
        var magazine = new Magazine(2);
        var rifle = new Rifle(false, magazine);
        //Act
        rifle.Recharge();
        rifle.Recharge();
        //Assert
        MyAssert.False(rifle.Chamber);
    }
    [MyFact]
    public void RechargingWithFuseOn()
    {
        //Arrange
        var magazine = new Magazine(2);
        var rifle = new Rifle(true, magazine);
        //Act + Assert
        MyAssert.Throws<InvalidOperationException>(() => rifle.Recharge());

    }

    [MyFact]
    public void FireWithTheFuseOnAndFullMagazine()
    {
        //Arrange
        var magazine = new Magazine(30);
        var rifle = new Rifle(true, magazine);
        //Act + Assert
        MyAssert.Null(rifle.Fire());
    }
    [MyFact]
    public void FireWithTheFuseOffAndFullMagazineWithEmptyChamber()
    {
        //Arrange
        var magazine = new Magazine(30);
        var rifle = new Rifle(false, magazine);
        //Act + Assert
        MyAssert.False(rifle.Chamber);
        MyAssert.Null(rifle.Fire());
    }
    [MyFact]
    public void FireWithTheFuseOffAndFullMagazineWithNotEmptyChamber()
    {
        //Arrange
        var magazine = new Magazine(30);
        Cartridge? cartridge = magazine.GetCartridge();
        magazine.AddCartridge(cartridge);
        
        var rifle = new Rifle(false, magazine);
        //Act + Assert
        MyAssert.False(rifle.Chamber);
        rifle.Recharge();
        MyAssert.Same(cartridge, rifle.Fire());
        MyAssert.False(rifle.Chamber);
    }
    
    [MyFact]
    public void RechargeWithEmptyMagazineAndFullChamber()
    {
        //Arrange
        var magazine = new Magazine(1);
        var rifle = new Rifle(false, magazine);
        //Act + Assert
        MyAssert.False(rifle.Chamber);
        rifle.Recharge();
        rifle.Recharge();
        MyAssert.False(rifle.Chamber);
    }
    
    [MyFact]
    public void RechargeWithEmptyMagazineAndEmptyChamber()
    {
        //Arrange
        var magazine = new Magazine(0);
        var rifle = new Rifle(false, magazine);
        //Act + Assert
        MyAssert.False(rifle.Chamber);
        MyAssert.Throws<InvalidOperationException>(() => rifle.Recharge());
    }

    [MyFact]
    public void FireWithEmptyMagazineEmptyChamberOffFuse()
    {
        //Arrange
        var magazine = new Magazine(0);
        var rifle = new Rifle(false, magazine);
        //Act + Assert
        MyAssert.False(rifle.Chamber);
        MyAssert.Null(rifle.Fire());
    }
    
 
}