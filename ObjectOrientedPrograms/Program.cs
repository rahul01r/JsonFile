using ObjectOrientedPrograms.Inventorymanagement;

namespace ObjectOrientedPrograms
{
    public class Program
    {
        const string INVENTORY_DATA_FILE_PATH = @"C:\Users\Lenovo\Desktop\Git\JsonFile\ObjectOrientedPrograms\Inventorymanagement\Inventory.json";
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select Programs\n 1.Inventory Management ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Inventory inventory = new Inventory();
                        inventory.ReadJsonFile(INVENTORY_DATA_FILE_PATH);
                        break;
                }
            }
        }
    }
}
