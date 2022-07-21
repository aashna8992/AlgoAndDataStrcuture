// See https://aka.ms/new-console-template for more information
using HashingAlgo;

Console.WriteLine("Hello, World!");

LinkedList llist1 = new LinkedList();
LinkedList llist2 = new LinkedList();
LinkedList unin = new LinkedList();
LinkedList intersecn = new LinkedList();

/*create a linked lists 10->15->5->20 */
llist1.push(20);
llist1.push(4);
llist1.push(15);
llist1.push(10);

/*create a linked lists 8->4->2->10 */
llist2.push(10);
llist2.push(2);
llist2.push(4);
llist2.push(8);
HashSet<int> set1 = new HashSet<int>();
intersecn.getUnionAndIntersection(llist1.head, llist2.head, set1);

Console.WriteLine("First List is");
llist1.printList();

Console.WriteLine("Second List is");
llist2.printList();
