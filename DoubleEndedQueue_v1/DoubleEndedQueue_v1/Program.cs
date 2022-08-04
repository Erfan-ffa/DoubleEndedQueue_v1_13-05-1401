using DoubleEndedQueue_v1;

DoubleEndedQueue x = new DoubleEndedQueue(10);

x.EnqueueFront(20);
x.EnqueueFront(30);

x.EnqueueBack(400);
x.EnqueueBack(45);
x.EnqueueBack(450);

Console.WriteLine("Items : ");
x.PrintMembers();
Console.WriteLine();
x.DequeuBack();
x.DequeuBack();
x.DequeuBack();
x.DequeuBack(); // error 

x.EnqueueBack(500);

x.DequeuBack();

x.DequeuBack(); // error 
x.DequeuBack(); // error 
x.DequeuBack(); // error 
x.DequeuBack(); // error 
x.DequeuBack(); // error 

x.DequeueFront();
x.DequeueFront();
x.DequeueFront(); // error 

x.EnqueueFront(500);
x.DequeueFront();

x.DequeueFront(); // error 
x.DequeueFront(); // error 


x.EnqueueBack(800);
x.EnqueueFront(5000);
Console.WriteLine("items");
x.PrintMembers();