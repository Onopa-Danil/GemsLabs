namespace Lab5;
public class Cartridge
{
    public bool Used { get; private set; }

    public Cartridge(bool used)
    {
        Used = used;
    }

    public void Use()
    {
        if (Used) throw new InvalidOperationException();
        Used = true;
    }
}