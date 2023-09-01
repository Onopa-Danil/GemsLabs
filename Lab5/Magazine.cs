namespace Lab5;

public class Magazine
{
    private Stack<Cartridge> Cartridges { get; set; }
    public int Count() => Cartridges.Count;

    public Magazine(int count)
    {
        if (count > 30) throw new InvalidOperationException();
        Cartridges = new Stack<Cartridge>(count);
        for (int i = 0; i < count; i++)
        {
            Cartridges.Push(new Cartridge(false));
        }
    }

    public Cartridge? GetCartridge()
    {
        if (!Cartridges.Any()) return null;
        return Cartridges.Pop();
    }

    public void AddCartridge(Cartridge cartridge)
    {
        if (cartridge is null || Cartridges.Count == 30 || cartridge.Used)
            throw new InvalidOperationException(); 
        Cartridges.Push(cartridge);
    }

    public bool Empty()
    {
        return !Cartridges.Any();
    }
}