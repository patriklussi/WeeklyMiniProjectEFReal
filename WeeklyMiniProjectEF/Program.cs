// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using System.Numerics;
using WeeklyMiniProjectEF;

Console.WriteLine("Welcome to your asset tracker");


MyDbContext Context = new MyDbContext(); //Db context 



string choice = "";
do
{
    List<Assets> AssetList = Context.Assets.Include(x => x.Office).OrderBy(x => x.Office.OfficeName).ThenBy(x => x.PurchaseDate).ToList(); // Getting the asset data and the related office data from the database
    Console.WriteLine("Select one of the following options");
    Console.WriteLine("(1) List the assets (Phones/Computers/Laptops) ");
    Console.WriteLine("(2) Add a new asset (Phone/Computer/Laptop)");
    Console.WriteLine("(3) Edit an asset");
    Console.WriteLine("(4) Delete an asset");
    Console.WriteLine("(5) Quit the application");

    choice = Console.ReadLine();
    if (choice == "1")
    {
        Console.WriteLine("Type".PadRight(14) + "Brand".PadRight(14) + "Model".PadRight(14) + "Office".PadRight(14) + "Purchase date".PadRight(14) + "Price in USD".PadRight(14) + "Currency".PadRight(14) + "Local price today".PadRight(14));
        foreach (Assets asset in AssetList)
        {
            Utilities.ResultPrinter(asset.AssetType, asset.Name, asset.Model, asset.PurchasePrice, asset.PurchaseDate, asset.Office.CurrencyType, asset.Office.OfficeName); //Static class method to print the data. 

        }
    }
    else if (choice == "2")
    {
        
        List<Office> offices = Context.Offices.ToList(); // Getting list of offices from database

        Console.Write("Asset type: ");
        string assetType = Console.ReadLine();

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Model: ");
        string model = Console.ReadLine();

        Console.Write("Purchase price: ");
        int price = int.Parse(Console.ReadLine());

        Console.Write("Purchase date (YYYY-MM-DD): ");
        DateTime purchaseDate = DateTime.Parse(Console.ReadLine());
        int selectedOfficeId = 0;

        Console.WriteLine("Select the office you want your asset to belong to");
        foreach (Office office in offices)
        {
         
    
            Console.WriteLine(office.Id+":" +" "+ office.OfficeName);
        
        }

        while (true)
        {
            Console.Write("Your choice: ");
            selectedOfficeId = int.Parse(Console.ReadLine());
            if(!(selectedOfficeId == 1 || selectedOfficeId == 2 || selectedOfficeId == 3)){
                Console.WriteLine("Try again by entering one of the allowed options");
            } else
            {
                break;
            }
        }

        Context.Assets.Update(new Assets { AssetType = assetType, Name = name, Model = model, PurchasePrice = price, PurchaseDate = purchaseDate, OfficeId = selectedOfficeId });//Adding new data to the database with a selected office.
        Context.SaveChanges();


    }
    else if (choice == "3")
    {
        int editChoice = 0;
        Console.WriteLine("Id".PadRight(5) + "Type".PadRight(10) + "Brand".PadRight(10) + "Model".PadRight(10) + "Office".PadRight(10) + "Purchase date".PadRight(15) + "Price in USD".PadRight(15) + "Currency".PadRight(10) + "Local price today".PadRight(10));
        foreach (Assets asset in AssetList.OrderBy(x => x.Id))
        {
            Utilities.ResultPrinterWithId(asset.Id, asset.AssetType, asset.Name, asset.Model, asset.PurchasePrice, asset.PurchaseDate, asset.Office.CurrencyType, asset.Office.OfficeName);


        }
        Console.Write("Choose a car to edit: ");
        editChoice = int.Parse(Console.ReadLine());
        Assets AssetsToEdit = Context.Assets.FirstOrDefault(x => x.Id == editChoice); //Selecting the asset in the list based on its id


        Console.Write("Asset type: ");
        string assetType = Console.ReadLine();


        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Model: ");
        string model = Console.ReadLine();

        Console.Write("Purchase price: ");
        int price = int.Parse(Console.ReadLine());

        Console.Write("Purchase date (YYYY-MM-DD): ");
        DateTime purchaseDate = DateTime.Parse(Console.ReadLine());



        AssetsToEdit.AssetType = assetType;
        AssetsToEdit.Name = name;
        AssetsToEdit.Model = model;
        AssetsToEdit.PurchasePrice = price;
        AssetsToEdit.PurchaseDate = purchaseDate;


        Context.Assets.Update(AssetsToEdit); //Adding the updated asset back to the list
        Context.SaveChanges();
        Console.WriteLine("Car has been updated");

    }
    else if (choice == "4")
    {
        int deleteChoice = 0;
        foreach (Assets asset in AssetList.OrderBy(x => x.Id))
        {
            Utilities.ResultPrinterWithId(asset.Id, asset.AssetType, asset.Name, asset.Model, asset.PurchasePrice, asset.PurchaseDate, asset.Office.CurrencyType, asset.Office.OfficeName);

        }
        Console.Write("Enter Id of item you wish to delete: ");

        deleteChoice = int.Parse(Console.ReadLine());
        Assets assetToDelete = Context.Assets.FirstOrDefault(x => x.Id == deleteChoice); //Selecting asset to be deleted by id
        Context.Assets.Remove(assetToDelete); // Deleting asset
        Context.SaveChanges();
        Console.WriteLine("Asset has been deleted");

    }

} while (choice != "5");



Console.WriteLine("Thank you for using the application");
