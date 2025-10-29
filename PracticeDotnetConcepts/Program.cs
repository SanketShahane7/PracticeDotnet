// See https://aka.ms/new-console-template for more information

Console.WriteLine("Application Started..!");

Console.WriteLine("\nBefore allocation:");
GCAllocation.ShowMemory();

///- Allocate large array memory
GCAllocation.AllocateMemory(30); // Allocate 30 MB
GCAllocation.ShowMemory();

///-- Clear reference to the large array
GCAllocation.ClearMemory();
Console.WriteLine("\nAfter clearing reference:");
GCAllocation.ShowMemory();

///-- Force garbage collection
GC.Collect();
GC.WaitForPendingFinalizers();

Console.WriteLine("\nAfter GC.Collect():");
GCAllocation.ShowMemory();

Console.WriteLine("\nApplication Ended..!!");