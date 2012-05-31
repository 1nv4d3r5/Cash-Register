using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cashRegister
{
    class ItemList
    {
        private LinkedList<Item> theList;
        private String str;
        private LinkedListNode<Item> current;
        private double tQuantity;
       
        public ItemList()
        {
            theList = new LinkedList<Item>();
            //current = theList.First;
        }

        public void addToLast(Item itObj)
        {
            theList.AddLast(itObj);
            //current = theList.First;
        }


        public void clearList()
        {
            theList.Clear();
        }

        public double getTotalQuantity()
        {
            tQuantity = 0.00;
            current = theList.First;

            while(current !=null)
            {
                tQuantity = tQuantity + (current.Value.getQuantity()*current.Value.getUnitPrice());
                current = current.Next;
            }

            return tQuantity;
        }


        public String displayList()
        {

            current = theList.First;
            str = "";
            while (current != null)
            {
                str = str + current.Value.toString();
                current = current.Next;
            }
            return str;
        }
    }
}
