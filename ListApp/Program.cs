using Microsoft.VisualBasic.FileIO;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        ListOfPushares library = new ListOfPushares();


        while (true)
        {
            Console.WriteLine("\nList Of Pushares System");
            Console.WriteLine("1. List all pushares");
            Console.WriteLine("2. Add a pushare");
            Console.WriteLine("3. Mark Purchased Pushare");
            Console.WriteLine("4. Remove Purchased Mark Pushare");
            Console.WriteLine("5. Delete a pushare");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    library.ListOfPushare();
                    break;
                case 2:
                    AddPushareToList(library);
                    break;
                case 3:
                    Console.Write("Enter the item name to add the purchased mark: ");
                    string pushareName = Console.ReadLine();
                    library.MarkPurchasedPushare(pushareName); 
                    break;

                case 4:
                    Console.Write("Enter the item name to remove the purchased mark: ");
                    pushareName = Console.ReadLine();
                    library.RemovePurchasedMarkPushare(pushareName);
                    break;
                case 5:
                    DeletePushare(library);
                    break;
                case 6:
                    return;
                case 7:
                    Console.WriteLine("Invalid choice, please try again!");
                    break;
            }
        }
    }
    private static void AddPushareToList(ListOfPushares library)
    {
        Console.Write("Enter pushare Name: ");
        string Name = Console.ReadLine();
        library.AddPushare(Name);
    }


    private static void DeletePushare(ListOfPushares library)
    {
        if (library.IsEmpty())
        {
            Console.WriteLine("There are no pushares to delete!");
            return;
        }

        Console.WriteLine("\nPushares:");
        library.ListOfPushare();

        Console.Write("Enter the name of the pushare to delete: ");
        string nameToDelete = Console.ReadLine();

        if (library.DeletePushare(nameToDelete))
        {
            Console.WriteLine("Pushare deleted successfully!");
        }
        else
        {
            Console.WriteLine("Pushare not found!");
        }
    }

}