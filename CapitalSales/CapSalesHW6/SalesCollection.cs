//COLLECTOR CLASS

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalSales
{
    public class SalesCollection
    {
        //dictionary collection which will hold all sales person
        Dictionary<string, SalesPerson> salesList = new Dictionary<string, SalesPerson>();

        public Dictionary<string, SalesPerson>.ValueCollection GetSalesPeople => salesList.Values;

        public void AddRecord(SalesPerson person)
        {
            salesList.Add(person.ID, person);
        }

        public void DeleteRecord(string ID)
        {
            salesList.Remove(ID);
        }

        public double RecordTotal()
        {
            double total = 0;
            foreach(SalesPerson person in GetSalesPeople)
            {
                total += person.Amount;
            }

            return total;
        }

        public SalesPerson FindSale(string IDInquiry)
        {
            SalesPerson saleFound = salesList.ContainsKey(IDInquiry) ? 
                                    salesList[IDInquiry] : null;

            return saleFound;
        }

        public override string ToString()
        {
            double total = 0;
            string output = $"{"ID",-10}{"Name",-15}{"Total"}\n";

            foreach (SalesPerson person in GetSalesPeople)
            {
                output += $"{person.ID,-10}{person.Name,-15}{person.Amount:C}\n";
                total += person.Amount;
            }
            output += $"{"".PadRight(30, '-')}";
            output += $"\n{"Total:",-25}{total:C}";
            return output;
        }
    }
}
