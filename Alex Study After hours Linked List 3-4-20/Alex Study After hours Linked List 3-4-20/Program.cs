using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alex_Study_After_hours_Linked_List_3_4_20
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> myList = new List<int> { };
            //myList.Add(1);
            //myList.Add(1);
            //myList.Add(1);
            //myList.Add(1);
            //myList.Add(1);
            //foreach (int item in myList)
            //{
            //    Console.WriteLine(item);
            //}

            //Linked List
            //This project gives a better understanding to C# linkedlists
            //Node and a Pointer to the next node

            Node firstNode = new Node(1);
            Node secondNode = new Node(2);
            secondNode.Next = firstNode;

            SinglyLinkedList mySList = new SinglyLinkedList();
            mySList.AddFirst(1);
            mySList.AddFirst(2);
            mySList.AddFirst(3);
            mySList.Append(10);
            mySList.Append(20);
            mySList.Append(30);

            mySList.InsertNode(11, 4);
            mySList.DeleteFirst();
            mySList.DeleteLast();
            mySList.AddFirst(4);
            mySList.AddLast(40);
            
            mySList.Print();

        }
        class Node
        {
            //To Store
            public int Value { get; set; }
            public Node Next { get; set; }

            public Node(int someValue)
            {
                Value = someValue;
            }
        }

        class SinglyLinkedList
        {
            //data
            Node head;

            //Behavior
            //add first
                public void AddFirst(int someValue)
            {
                //create new node
                Node newnode = new Node(someValue);
                //link the new node
                newnode.Next = head;
                //move head to the left
                head = newnode;
            }

            //add last/append
            public void Append(int someValue)
            {
                AddLast(someValue);
            }
            public void AddLast(int someValue)
            {
                if (head == null)
                {
                    AddFirst(someValue);
                    return;

                }
                Node newNode = new Node(someValue);

                Node finger = head;

                while (finger.Next != null)
                {
                    finger = finger.Next;


                }
                finger.Next = newNode;
            }

            //Delete First
            public void DeleteFirst()
            {
                if (head == null)
                    throw new Exception("You can't delete first if there is nothing in the list");
                else
                head = head.Next;//moves head to  the next node and gives the next value to the GC(garbage collector) 
            }

            //Delete Last
            public void DeleteLast()
            {
                if (head == null || head.Next == null)
                {
                    throw new Exception("You can' Delete the last node in a empty list");

                }
                Node finger = head;

                while(finger.Next.Next != null)
                {
                    finger = finger.Next;
                }
                //Finger points to the node next 
                finger.Next = null;

            }

            //insert
            public void InsertNode(int someValue, int index)
            {
                //create new node
                if(index == 0 && (head == null))
                {
                    AddFirst(someValue);
                    return;
                }
                //Create a new node
                Node newNode = new Node(someValue);
                //Finding the node at index -1
                Node finger = head;
                for (int pos = 0; pos < index - 1; pos++)
                {
                    if(finger==null)
                    {
                        Console.WriteLine("Error1");
                        return;
                    }
                    finger = finger.Next;
                }
                newNode.Next = finger.Next;
                finger.Next = newNode;
            }


            //Delete
            public void Delete(int index)
            {
                if(index<0)
                {
                    return;
                }
                if(index == 0)
                {
                    DeleteFirst();
                }
                else
                {
                    Node finger = head;
                    for (int pos = 0; pos < index - 1; pos++)
                    {
                        if(finger == null)
                        {
                            Console.WriteLine("Error");
                            return;
                        }
                        finger = finger.Next;
                    }
                    if (finger != null && finger.Next != null)
                    {
                        finger.Next = finger.Next.Next;
                    }
                    else
                        Console.WriteLine("Error2");

                }

            }

            //Print/traverse
                public void Print()
            {
                if(head == null)//If the list is empty
                    Console.WriteLine("List is Empty");
                else
                {
                    Node finger = head;
                    while(finger !=null)
                    {
                        Console.WriteLine(finger.Value);
                        finger = finger.Next;//moves finger to the right
                    }
                }
            }

            //constructor

            public SinglyLinkedList()
            {
                //head = null
            }
        }


    }
}
