public class ListOfPushares
{
    private List<Pushares> pushares;

    public ListOfPushares()
    {
        pushares = new List<Pushares>();
    }

    public void AddPushare(string name)
    {
        pushares.Add(new Pushares(name));
        Console.WriteLine($"Pushare added: {name}");
    }

    public void ListOfPushare()
    {
        if (IsEmpty())
        {
            Console.WriteLine("There are no pushares in the list.");
            return;
        }

        Console.WriteLine("List of Pushares:");
        foreach (Pushares pushare in pushares)
        {
            Console.WriteLine($"{pushare.Name}");
        }
    }

    public bool DeletePushare(string name)
    {
        int index = pushares.FindIndex(p => p.Name == name);
        if (index != -1)
        {
            pushares.RemoveAt(index);
            Console.WriteLine($"Pushare deleted: {name}");
            return true;
        }
        else
        {
            Console.WriteLine($"Pushare '{name}' not found!");
            return false;
        }
    }

    public bool IsEmpty()
    {
        return pushares.Count == 0;
    }

    public void MarkPurchasedPushare(string name)
    {
        int index = pushares.FindIndex(p => p.Name == name);
        if (index != -1)
        {
            pushares[index].IsPurchased = true;
            Console.WriteLine($"Pushare '{name}' marked as purchased.");
        }
        else
        {
            Console.WriteLine($"Pushare '{name}' not found!");
        }
    }

    public void RemovePurchasedMarkPushare(string name)
    {
        int index = pushares.FindIndex(p => p.Name == name);
        if (index != -1)
        {
            pushares[index].IsPurchased = false;
            Console.WriteLine($"Purchased mark removed from pushare '{name}'.");
        }
        else
        {
            Console.WriteLine($"Pushare '{name}' not found!");
        }
    }

    public void ShowPurchasedPushares()
    {
        if (IsEmpty())
        {
            Console.WriteLine("There are no pushares in the list.");
            return;
        }

        Console.WriteLine("List of Purchased Pushares:");
        foreach (Pushares pushare in pushares.Where(p => p.IsPurchased))
        {
            Console.WriteLine($"{pushare.Name}");
        }
    }
}