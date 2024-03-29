﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cashRegister
{
    class ItemList
    {
        private LinkedList<Item> list;
        private String str;
        private LinkedListNode<Item> current;
        private double tQuantity;
       
        public ItemList()
        {
            list = new LinkedList<Item>();
        }

        public void addToLast(Item itObj)
        {
            list.AddLast(itObj);
        }


        public void clearList()
        {
            list.Clear();
        }

        public double getTotalQuantity()
        {
            tQuantity = 0.00;
            current = list.First;

            while(current !=null)
            {
                tQuantity = tQuantity + (current.Value.getQuantity()*current.Value.getUnitPrice());
                current = current.Next;
            }

            return tQuantity;
        }


        public String displayList()
        {

            current = list.First;
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
