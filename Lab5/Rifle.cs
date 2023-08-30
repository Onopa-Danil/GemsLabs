namespace Lab5;

public class Rifle
{
    public bool Fuse { get; set; }
    public bool Chamber { get; private set; }
    public Magazine Cartridges { get; set; }
    private Cartridge? _cartridgeInChamber;

    public Rifle(bool fuse, Magazine cartridges)
    {
        Fuse = fuse;
        Chamber = false;
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
                Chamber = true;
                return null;
            }

            Cartridge cartridge = _cartridgeInChamber;
            _cartridgeInChamber = null;
            Chamber = false;
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