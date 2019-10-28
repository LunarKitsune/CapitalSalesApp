//FILE PROCESSOR CLASS

//doing a using with the stream reader or writer implements an IDisposable to the object
//when a stream writer/stream reader object goes out of scope it is disposed and
//automatically closed. 

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalSales
{
    public class fileProcessor
    {
        string salesLogFile = "Sales.txt";

        public void LogSales(SalesCollection salesCollection)
        {
            using (StreamWriter fileWriter = File.CreateText(salesLogFile))
            {
                foreach(SalesPerson salesItem in salesCollection.GetSalesPeople)
                {
                    fileWriter.WriteLine($"{salesItem.ID},{salesItem.Name},{salesItem.Amount}");
                }
            }
        }

        public void readSalesFile(SalesCollection salesCollection)
        {
            if(File.Exists(salesLogFile))
            {
                using (StreamReader fileReader = new StreamReader(salesLogFile))
                {
                    while (!fileReader.EndOfStream)
                    {
                        string line = fileReader.ReadLine();
                        string[] splitline = line.Split(',');
                        SalesPerson person = new SalesPerson()
                        { ID = splitline[0], Name = splitline[1], Amount = double.Parse(splitline[2]) };

                        salesCollection.AddRecord(person);
                    }
                }
            }
        }
    }
}
