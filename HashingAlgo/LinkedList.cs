using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashingAlgo
{
    class LinkedList
    {
        public Node head; // head of list

        /* Linked list Node*/
        public class Node
        {
            public int data;
            public Node next;
            public Node(int d)
            {
                data = d;
                next = null;
            }
        }

        /* Utility function to print list */
        public void printList()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }

        public void push(int n)
        {
            if(head == null)
            {
                head = new Node(n);
            }
            else
            {
                Node current = head;
                while(current.next != null)
                {
                    current = current.next;
                }
                current.next = new Node(n);
            }
        }

        public void getUnionAndIntersection(Node head1, Node head2, HashSet<int> set1)
        {
            Node Current1 = head1;
            LinkedList inter = new LinkedList();
            set1.Add(Current1.data);
            while (Current1.next != null)
            {
                set1.Add(Current1.next.data);
                Current1 = Current1.next;
            }

            Node Current2 = head2;
            while (Current2 != null)
            {
                if (set1.Contains(Current2.data))
                {
                    inter.push(Current2.data);
                }
                else
                {
                    set1.Add(Current2.data);
                }
                Current2 = Current2.next;
            }

            inter.printList();
            Console.WriteLine("printing union");
            set1.ToList();
            foreach(int i in set1)
            {
                Console.WriteLine(i);
            }
        }

    }
}
