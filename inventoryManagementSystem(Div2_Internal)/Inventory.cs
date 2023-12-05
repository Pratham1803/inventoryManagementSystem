using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventoryManagementSystem_Div2_Internal_
{
    internal class Inventory
    {
        public int id {  get; set; }
        public string serialNum { get; set; }
        public string name { get; set; }
        public int Quantity { get; set; }
        public int price { get; set; }
        public string brand { get; set; }
    }
}
