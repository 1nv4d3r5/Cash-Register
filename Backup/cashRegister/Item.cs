using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cashRegister
{
    class Item
    {
        private String itemName;
        private int itemQuantity;
        private Double unitPrice;
        private String strData;

        public Item()
        {
            itemName = "";
            itemQuantity = 0;
            unitPrice = 0.00;
        }

        /*public Item(String name, int quantity, double price)
        {
            itemName = name;
            itemQuantity = quantity;
            unitPrice = price;
        }
        */
        public void setName(String n)
        {
            itemName = n;
            
        }

        public void setQuantity(int q)
        {
            itemQuantity = q;
        }

        public void setUnitprice(double p)
        {
            unitPrice = p;
        }
        
        public string getName()
        {
            return itemName;
        }

        public int getQuantity()
        {
            return itemQuantity;
        }

        public double getUnitPrice()
        {
            return unitPrice;
        }

        public String toString()
        {
            strData = "Name     :    " + itemName + "\n" + "Quantity :    " + itemQuantity + "\n" + "Price      : $ " + unitPrice + "\n" + "--------------------------------------------------------------------" + "\n";
           return strData;
        }

    }
}
