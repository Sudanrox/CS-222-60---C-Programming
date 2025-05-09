using System;

class Program
{
    static void Main()
    {
        // Print a header row with column names
        Console.WriteLine("{0,-10} {1,-15} {2,30} {3,30}", "Type", "Byte(s) of memory", "Min", "Max");

        // Display information for different number types
        DisplayTypeInfo<sbyte>();   // Signed byte
        DisplayTypeInfo<byte>();    // Unsigned byte
        DisplayTypeInfo<short>();   // Short integer
        DisplayTypeInfo<ushort>();  // Unsigned short integer
        DisplayTypeInfo<int>();     // Integer
        DisplayTypeInfo<uint>();    // Unsigned integer
        DisplayTypeInfo<long>();    // Long integer
        DisplayTypeInfo<ulong>();   // Unsigned long integer
        DisplayTypeInfo<float>();   // Single-precision floating point
        DisplayTypeInfo<double>();  // Double-precision floating point
        DisplayTypeInfo<decimal>(); // Decimal type for high-precision numbers
    }

    // This method prints the type name, memory size, min, and max value for the given data type
    static void DisplayTypeInfo<T>() where T : struct
    {
        Console.WriteLine("{0,-10} {1,-15} {2,30} {3,30}",
            typeof(T).Name, // Get the name of the type (like int, float, etc.)
            System.Runtime.InteropServices.Marshal.SizeOf(typeof(T)), // Get how many bytes it uses
            GetMinValue<T>(), // Get the minimum value of this type
            GetMaxValue<T>()  // Get the maximum value of this type
        );
    }

    // This method returns the minimum value of the type using reflection
    static object GetMinValue<T>()
    {
        return typeof(T).GetField("MinValue").GetValue(null);
    }

    // This method returns the maximum value of the type using reflection
    static object GetMaxValue<T>()
    {
        return typeof(T).GetField("MaxValue").GetValue(null);
    }
}
