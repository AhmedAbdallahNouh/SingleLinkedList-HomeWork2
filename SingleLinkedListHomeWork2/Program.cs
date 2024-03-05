// See https://aka.ms/new-console-template for more information
using SingleLinkedListHomeWork2.Classes;

#region problem 1 Execution


SingleLinkedList singleLinkedList = new SingleLinkedList();

singleLinkedList.InsertEnd(20);
singleLinkedList.InsertEnd(30);
singleLinkedList.InsertEnd(15);
singleLinkedList.InsertEnd(55);

int value = 30;

singleLinkedList.Print();
Console.WriteLine("\n");


int nodeIndex = singleLinkedList.DeleteNodeWithkey(value);

if (nodeIndex != -1)
	Console.WriteLine($"Linked List After Delete Node : {nodeIndex}");
else
	Console.WriteLine($"Node With Value : {value} Not Found");

Console.WriteLine("\n");
singleLinkedList.Print();
Console.WriteLine("\n");


#endregion


#region problem 2 Execution

Console.ForegroundColor = ConsoleColor.Magenta;

SingleLinkedList LinkedListToSwapEachPairs = new SingleLinkedList();

////singleLinkedList.Print();

LinkedListToSwapEachPairs.InsertEnd(1);
LinkedListToSwapEachPairs.InsertEnd(2);
LinkedListToSwapEachPairs.InsertEnd(3);
LinkedListToSwapEachPairs.InsertEnd(4);
LinkedListToSwapEachPairs.InsertEnd(5);

LinkedListToSwapEachPairs.SwapPairs();

LinkedListToSwapEachPairs.Print();
Console.WriteLine("\n");


if (nodeIndex != -1)
	Console.WriteLine($"Linked List After Delete Node : {nodeIndex}");
else
	Console.WriteLine($"Node With Value : {value} Not Found");

Console.WriteLine("\n");
singleLinkedList.Print();
Console.WriteLine("\n");


#endregion

#region problem 4 Execution

Console.ForegroundColor = ConsoleColor.Red;

SingleLinkedList LinkedListToRrverse = new SingleLinkedList();

LinkedListToRrverse.InsertEnd(1);
LinkedListToRrverse.InsertEnd(2);
LinkedListToRrverse.InsertEnd(3);
LinkedListToRrverse.InsertEnd(4);
LinkedListToRrverse.InsertEnd(5);

LinkedListToRrverse.Print();

Console.WriteLine("\n");
Console.WriteLine("Linked List After Reversed ");
Console.WriteLine("\n");

LinkedListToRrverse.Reverse();

LinkedListToRrverse.Print();
Console.WriteLine("\n");


#endregion

#region problem 4 Execution

Console.ForegroundColor = ConsoleColor.Green;

SingleLinkedList LinkedListToDeleteEvenPositions = new SingleLinkedList();

LinkedListToDeleteEvenPositions.InsertEnd(9);
LinkedListToDeleteEvenPositions.InsertEnd(10);
LinkedListToDeleteEvenPositions.InsertEnd(11);
LinkedListToDeleteEvenPositions.InsertEnd(12);
LinkedListToDeleteEvenPositions.InsertEnd(13);

LinkedListToDeleteEvenPositions.Print();

Console.WriteLine("\n");
Console.WriteLine("Linked List After Deleted All Even Positions ");

LinkedListToDeleteEvenPositions.DeleteEvenPositions();
Console.WriteLine("\n");
LinkedListToDeleteEvenPositions.Print();
Console.WriteLine("\n");


#endregion


#region problem 5 Execution

Console.ForegroundColor = ConsoleColor.Cyan;

SingleLinkedList sortedLinkedList = new SingleLinkedList();


sortedLinkedList.InsertSorted(10);
sortedLinkedList.InsertSorted(2);
sortedLinkedList.InsertSorted(30);
sortedLinkedList.InsertSorted(4);
sortedLinkedList.InsertSorted(1);


Console.WriteLine("\n");
Console.WriteLine("Sorted Linked List After Inserted All Values");
Console.WriteLine("\n");
sortedLinkedList.Print();
Console.WriteLine("\n");


#endregion