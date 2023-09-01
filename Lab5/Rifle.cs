namespace Lab5;

public class Rifle
{
    public bool Fuse { get; set; }
    public bool Chamber => _cartridgeInChamber is not null;
    public Magazine Cartridges { get; set; }
    private Cartridge? _cartridgeInChamber;

    public Rifle(bool fuse, Magazine cartridges)
    {
        Fuse = fuse;
        Cartridges = cartridges;
    }

    public Cartridge? Recharge()
    {
        if (!Fuse)
        {
            if (_cartridgeInChamber is null)
            {
                if (Cartridges.Empty())
                    throw new InvalidOperationException();
                _cartridgeInChamber = Cartridges.GetCartridge();
                return null;
            }

            Cartridge cartridge = _cartridgeInChamber;
            _cartridgeInChamber = null;
            return cartridge;
        }

        throw new InvalidOperationException();
    }

    public Cartridge? Fire()
    {
        if (Fuse || !Chamber) return null;
        Cartridge? sleeve = Recharge();
        sleeve.Use();
        return sleeve;
    }
}