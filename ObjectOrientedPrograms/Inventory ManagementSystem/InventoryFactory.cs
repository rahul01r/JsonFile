using Newtonsoft.Json;
using ObjectOrientedPrograms.Inventorymanagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPrograms.Inventory_ManagementSystem
{
    public class InventoryFactory
    {
        InventoryManagement inventory = new InventoryManagement();
        public void ReadJsonFile(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                var json = reader.ReadToEnd();
                this.inventory = JsonConvert.DeserializeObject<InventoryManagement>(json);
                Display(this.inventory.RiceList, "RiceList");
                Display(this.inventory.WheatList, "WheatList");
                Display(this.inventory.PulsesList, "PulsesList");
            }
        }
        public void AddInventory(string inventoryName, InventoryDetails details)
        {
            if (inventoryName == "RiceList")
            {
                this.inventory.RiceList.Add(details);
            }
            if (inventoryName == "WheatList")
            {
                this.inventory.WheatList.Add(details);
            }
            if (inventoryName == "PulsesList")
            {
                this.inventory.PulsesList.Add(details);
            }
        }
        public void DeleteInventory(string inventoryName, string inventoryDetailsName)
        {
            if (inventoryName == "RiceList")
            {
                foreach (var data in this.inventory.RiceList)
                {
                    if (data.Name == inventoryDetailsName)
                    {
                        this.inventory.RiceList.Remove(data);
                        return;
                    }
                }
                Console.WriteLine("Inventory does not exist");
            }

            if (inventoryName == "WheatList")
            {
                foreach (var data in this.inventory.WheatList)
                {
                    if (data.Name == inventoryDetailsName)
                    {
                        this.inventory.WheatList.Remove(data);
                        return;
                    }
                }
                Console.WriteLine("Inventory does not exist");
            }

            if (inventoryName == "PulsesList")
            {
                foreach (var data in this.inventory.PulsesList)
                {
                    if (data.Name == inventoryDetailsName)
                    {
                        this.inventory.PulsesList.Remove(data);
                        return;
                    }
                }
                Console.WriteLine("Inventory does not exist");
            }
        }
        
        public void WriteTojson(string filePath)
        {
            var json = JsonConvert.SerializeObject(this.inventory);
            File.WriteAllText(filePath, json);
        }
        public void Display(List<InventoryDetails> list, string inventoryName)
        {
            Console.WriteLine("Inventory is:" + inventoryName);
            Console.WriteLine("Name" + "\t" + "Weight" + "\t" + "price");
            foreach (var data in list)
            {
                Console.WriteLine(data.Name + "\t" + data.Weight + "\t" + data.Price);
            }
        }

    }
}

