using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClassLibrary
{
    public class Store
    {
        public List<Car> CarList { get; set; }
        public List<Car> ShopList { get; set; }

        public Store()
        {
            CarList = new List<Car>();
            ShopList = new List<Car>();
        }

        public decimal CheckOut()
        {
            decimal TotalCost = 0;

            foreach (var item in ShopList)
            {
                TotalCost = TotalCost + item.Price;
            }

            ShopList.Clear();
            return TotalCost;
        }

       
    }

}
