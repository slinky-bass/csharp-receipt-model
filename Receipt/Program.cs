using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receipt
{
	class Program
	{
		public static void Main(string[] args)
		{
			Cashier c1 = new Cashier() {
                id = 1,
                name = "Bob"
            };
			
			Cashier c2 = new Cashier() {
                id = 2,
                name = "Jack"
            };

            Console.WriteLine(String.Format("Employee name: {0}, Employee id: {1}", c1.name, c1.id));
            //Console.WriteLine("Employee name: {0}, Employee id: {1}", c1.name, c1.id);
            
            StoreSale sale1 = StoreSale.NewSale(c1);
            Console.WriteLine(String.Format("SaleNumber: {0}, Cashier: {1}", sale1.CreatedAt.ToString("dd/MM/yyyy hh:mm:ss.fff"), sale1.CurrentCashier.name));
            
            StoreSale sale2 = StoreSale.NewSale(c2);
            Console.WriteLine(String.Format("SaleNumber: {0}, Cashier: {1}", sale2.CreatedAt.ToString("dd/MM/yyyy hh:mm:ss.fff"), sale2.CurrentCashier.name));
            Console.ReadLine();
		}
	}
}
