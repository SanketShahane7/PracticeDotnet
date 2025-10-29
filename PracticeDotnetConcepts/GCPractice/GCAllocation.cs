using System;

class GCAllocation
{
    public static byte[] data { get; private set; }
    public static byte[] data2 { get; private set; }

    public static void AllocateMemory(int sizeInMB = 10)
    {
        Console.WriteLine("\nAllocating memory...");

        ///-- Allocate large array memory
        data = new byte[sizeInMB * 1024 * 1024]; // Allocate specified MB
        data2 = new byte[2 * sizeInMB * 1024 * 1024]; // Allocate specified MB * 2

        Console.WriteLine("Allocation complete.");
    }

    public static void ShowMemory()
    {
        long memory = GC.GetTotalMemory(false);
        Console.WriteLine($"Total memory: {memory / 1024 / 1024} MB");
    }

    public static void ClearMemory()
    {
        data = null;
    }
}