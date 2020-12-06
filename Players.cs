using System;
using System.Collections.Generic;
using System.Text;

namespace HW2
{
    class Players
    {
        //add data variables for the number of players in the player array
        public int numPlayers;
        public SeLinkList headNode; // add variable with the linked list type to serve as the first head node in the list

        public Players()
        {
            numPlayers = 0; // initialize numPlayers variable to 0 to start
            headNode = null;// set linked list head node to null because no values are added yet
        }

        public void AddPlayer(int a, int b, int c) // add player method that will add players to the end of the list
        {
            SeLinkList node = new SeLinkList(a,b,c); // initial new list
            

            if (headNode == null) //if no nodes are currently in the list add first value to head of list
            {
                headNode = node; // current node becomes head node
            }
            else
            {
                SeLinkList tempNode = headNode; // If node isnt the first node in the list it will be placed at the end of the list
                while (tempNode.next != null)
                {
                    tempNode = tempNode.next;
                }
                tempNode.next = node; // linked list is a doubly linked list so there is a pointer to prev and next node in the sequence
                node.prev = tempNode;
            }
            numPlayers++; // increment number of players as they are added to the list
        }

        public void InitializeList() // loop to add data to list
        {
            foreach(PlayerData nodeInfo in myData)
            {
                AddPlayer(nodeInfo.a, nodeInfo.b, nodeInfo.c);
            }
        }

        public void PrintList() // method to print all nodes in the list using Print node method in seLinkList class
        {
            Console.WriteLine("The linked list is now printing!");
            Console.WriteLine();
            SeLinkList node = headNode;
            while(node != null)
            {
                node.PrintNode();
                node = node.next;
            }
        }

        public void FindMaxWeight() // find the node with the maximum weight
        {
            int maxWeight = int.MinValue; // set the max node to the minimium value so value can be compared against current max value in the list
            SeLinkList maxNode = null;
            SeLinkList node = headNode;
            while(node != null)
            {
                if(node.GetWeight() > maxWeight) // if the value obtained is greater than the maximum value set the max value to this node
                {
                    maxWeight = node.GetWeight();
                    maxNode = node;
                }
                node = node.next;
            }

            Console.WriteLine(" Here is the node with the maximum value"); // print max node value
            maxNode.PrintNode();
            
        }

        public void FindMinWeight() 
        {
            int minWeight = int.MaxValue; // set minimum weight to max value to compare node to the heaviest node in the list
            SeLinkList minNode = null;
            SeLinkList node = headNode;

            while (node != null)
            {
                if (node.GetWeight() < minWeight) // if the node is lesser than a heavier node set the node to the minimum node in the list
                {
                    minWeight = node.GetWeight();
                    minNode = node;
                }
                
                node = node.next;
            }

            Console.WriteLine(" Here is the node with the most minimium value");
            minNode.PrintNode();

        }

        public struct PlayerData // set data items for Player data
        {
            public int a;
            public int b;
            public int c;
            

            public PlayerData(int dataA, int dataB, int dataC) // set vavariable for myData array
            {
                a = dataA;
                b = dataB;
                c = dataC;
            }
        }

        public PlayerData[] myData = new PlayerData[]
        {
         new PlayerData( 22, 9, 9 ),
         new PlayerData( 3, 26, 9 ),
         new PlayerData( 23, 24, 1 ),
         new PlayerData( 20, 13, 6 ),
         new PlayerData( 15, 19, 2 ),
         new PlayerData( 14, 4, 24 ),
         new PlayerData( 3, 6, 14 ),
         new PlayerData( 10, 10, 11 ),
         new PlayerData( 5, 7, 22 ),
         new PlayerData( 1, 11, 0 ),
         new PlayerData( 26, 19, 24 ),
         new PlayerData( 5, 28, 9 ),
         new PlayerData( 6, 24, 17 ),
         new PlayerData( 29, 22, 24 ),
         new PlayerData( 24, 10, 22 ),
         new PlayerData( 22, 11, 13 ),
         new PlayerData( 7, 12, 27 ),
         new PlayerData( 3, 11, 22 ),
         new PlayerData( 16, 12, 28 ),
         new PlayerData( 28, 28, 19 ),
         new PlayerData( 17, 21, 13 ),
         new PlayerData( 1, 24, 23 ),
         new PlayerData( 12, 10, 20 ),
         new PlayerData( 22, 8, 10 ),
         new PlayerData( 6, 3, 13 ),
         new PlayerData( 19, 15, 0 ),
         new PlayerData( 19, 13, 25 ),
         new PlayerData( 8, 24, 28 ),
         new PlayerData( 2, 23, 8 ),
         new PlayerData( 2, 18, 16 ),
         new PlayerData( 11, 8, 26 ),
         new PlayerData( 27, 11, 1 ),
         new PlayerData( 11, 23, 16 ),
         new PlayerData( 28, 9, 1 ),
         new PlayerData( 22, 14, 4 ),
         new PlayerData( 17, 26, 7 ),
         new PlayerData( 8, 27, 27 ),
         new PlayerData( 27, 9, 15 ),
         new PlayerData( 23, 9, 27 ),
         new PlayerData( 14, 28, 1 ),
         new PlayerData( 14, 9, 21 ),
         new PlayerData( 4, 11, 0 ),
         new PlayerData( 14, 9, 22 ),
         new PlayerData( 12, 8, 22 ),
         new PlayerData( 14, 20, 3 ),
         new PlayerData( 23, 15, 10 ),
         new PlayerData( 24, 15, 26 ),
        };


    }
}

    

