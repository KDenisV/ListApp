public class Pushares
{
    public string Name { get; set; }
    public bool IsPurchased { get; set; }

    public Pushares(string name)
    {
        Name = name;
        IsPurchased = false;
    }
}
