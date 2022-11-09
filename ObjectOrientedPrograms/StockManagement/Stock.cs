using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPrograms.StockManagement
{
    public class Stock
    {
        List<StockDetails> details = new List<StockDetails>();

        public void ReadJsonFile(string fileName)
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                var json = reader.ReadToEnd();
                this.details = JsonConvert.DeserializeObject<List<StockDetails>>(json);
                Console.WriteLine("Name" + "\t" + "Share" + "\t" + "SharePrice" + "\t" + "TotalSharePrice");
                foreach (var data in details)
                {
                    Console.WriteLine(data.Name + "\t" + data.Share + "\t" + data.SharePrice + "\t" + data.Share * data.SharePrice);
                }
            }
        }
    }
}
