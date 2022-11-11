using ObjectOrientedPrograms.Inventory_ManagementSystem;
using ObjectOrientedPrograms.Inventorymanagement;
using ObjectOrientedPrograms.StockManagement;
using ObjectOrientedPrograms.StockManagementSystem;
using Stock = ObjectOrientedPrograms.StockManagementSystem.Stock;

namespace ObjectOrientedPrograms
{
    public class Program
    {
        const string INVENTORY_DATA_FILE_PATH = @"C:\Users\Lenovo\Desktop\Git\JsonFile\ObjectOrientedPrograms\Inventorymanagement\Inventory.json";
        const string INVENTORYDETAILS_DATA_FILE_PATH = @"C:\Users\Lenovo\Desktop\Git\JsonFile\ObjectOrientedPrograms\Inventory ManagementSystem\InventoryDetails.json";
        const string STOCKDETAILS_DATA_FILE_PATH = @"C:\Users\Lenovo\Desktop\Git\JsonFile\ObjectOrientedPrograms\StockManagement\StockDetails.json";
        const string STOCK_DATA_FILE_PATH = @"C:\Users\Lenovo\Desktop\Git\JsonFile\ObjectOrientedPrograms\StockManagementSystem\Stock.json";
        const string COMPANY_DATA_FILE_PATH = @"C:\Users\Lenovo\Desktop\Git\JsonFile\ObjectOrientedPrograms\StockManagementSystem\Company.json";

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select Programs\n 1.Inventory Management \n2.Inventory Manangement System \n3.Stock Management\n4.Stock Management System ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Inventory inventory = new Inventory();
                        inventory.ReadJsonFile(INVENTORY_DATA_FILE_PATH);
                        break;
                    case 2:
                        InventoryFactory inventoryFactory = new InventoryFactory();
                        inventoryFactory.ReadJsonFile(INVENTORYDETAILS_DATA_FILE_PATH);
                        InventoryDetails details = new InventoryDetails()

                        {
                            Name = "a",
                            Weight = 5,
                            Price = 25
                        };
                        inventoryFactory.AddInventory("WheatList", details);
                        //inventoryFactory.DeleteInventory("WheatList", "a");
                        inventoryFactory.WriteTojson(INVENTORYDETAILS_DATA_FILE_PATH);
                        break;
                    case 3:
                        //Stock stock = new Stock();
                        //stock.ReadJsonFile(STOCKDETAILS_DATA_FILE_PATH);
                        //break;
                    case 4:
                        Stock1Management stockManagement = new Stock1Management();
                        stockManagement.ReadJsonFileStock(STOCK_DATA_FILE_PATH);
                        stockManagement.ReadJsonFileCompany(COMPANY_DATA_FILE_PATH);
                        //Company company = new Company()
                        Stock stock = new Stock()
                        {
                            Name = "Facebook",
                            NoOfShares = 5,
                            PricePerShare = 250,
                        };
                        stockManagement.SellStockShares(stock);
                        //stockManagement.BuyCompanyShares(company);
                        stockManagement.WriteToJsonStock(STOCK_DATA_FILE_PATH);
                        stockManagement.WriteToJsoncompany(COMPANY_DATA_FILE_PATH);
                        break;

                }
            }
        }
    }
}
