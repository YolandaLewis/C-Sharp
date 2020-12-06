using System;
using System.Collections.Generic;
using System.Text;

namespace HW2
{
    class SeLinkList
    {
        // set public data variables for linked list class
        private static int listIndexCounter; 
        public SeLinkList next;
        public SeLinkList prev;
        private int a;
        private int b;
        private int c;
        private int index;


        public SeLinkList() //create doubly linked list constructor with data items
        {
            listIndexCounter = 0;
            next = null;
            prev = null;
            index = 0; 
            a = 0;
            b = 0;
            c = 0; 
        }

        public SeLinkList (int _a, int _b, int _c) // constructor for doubly linked list
        {
            next = null; // set next and prev so that list can be traversed in both directions
            prev = null;
            a = _a;
            b = _b;
            c = _c;
            index = listIndexCounter; // variable to keep count of list indexes
            listIndexCounter++;
        }
        

        public int GetWeight() // add player data to get the most heaviest node
        {
            return a+b+c;
        }

        public int GetIndex() // return index of node in the list
        {
            return index;
        }

        public void PrintNode()//  method for format to display player data and current index of the node containing the player data
        {
            Console.WriteLine("Current Node Index: {0}", index);
            Console.WriteLine(" Player Data value a: {0}", a);
            Console.WriteLine(" Player Data value b: {0}", b);
            Console.WriteLine(" Player Data value c: {0}", c);
            Console.WriteLine();


        }
          
    }
}
