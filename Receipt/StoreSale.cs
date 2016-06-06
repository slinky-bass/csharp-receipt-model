using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receipt
{
	/// <summary>
	/// Description of StoreSale.
	/// </summary>
	public class StoreSale
	{
		private DateTime _CreatedAt;
		private Cashier _CurrentCashier;
		
		public DateTime CreatedAt
		{
			get
			{
				//return what ever _CurrentCashier is set to
				return _CreatedAt;
			} 
			set 
			{
				//Set the field to whatever value is passed in
				_CreatedAt = value;
			}
		}
        
		public Cashier CurrentCashier
		{
			get
			{
				//return what ever _CurrentCashier is set to
				return _CurrentCashier;
			} 
			set 
			{
				//Set the field to whatever value is passed in
				_CurrentCashier = value;
			}
		}

        public static StoreSale NewSale(Cashier NewCashier) {
        	StoreSale sale = new StoreSale();
        	sale.CreatedAt = DateTime.Now;
            sale.CurrentCashier = NewCashier;

            //Console.WriteLine("CreatedAt: {0}, CurrentCashier: {1}", CreatedAt, CurrentCashier.name);
            //Console.ReadLine();
            
            return sale;
        }
	}
}
