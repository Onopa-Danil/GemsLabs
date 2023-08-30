namespace Lab5;

public class Magazine
{
    private Queue<Cartridge> Cartridges { get; set; }
    public int Count() => Cartridges.Count;

    public Magazine(int count)
    {
        if (count > 30) throw new InvalidOperationException();
        Cartridges = new Queue<Cartridge>(count);
        for (int i = 0; i < count; i++)
        {
            Cartridges.Enqueue(new Cartridge(false));
        }
    }

    public Cartridge? GetCartridge()
    {
        if (!Cartridges.Any()) return null;
        return Cartridges.Dequeue();
    }

    public void AddCartridge(Cartridge cartridge)
    {
        if (Cartridges.Count == 30 || cartridge.Used)
            throw new InvalidOperationException(); 
        Cartridges.Enqueue(cartridge);
    }

    public bool Empty()
    {
        return !Cartridges.Any();
    }
}