

namespace _1_lab
{

    public class PrintAll
    {
        static void Main()
        {
            Console.WriteLine("{0} size:{1}; min : {3}; max: {2} ", typeof(bool), sizeof(bool), bool.TrueString,
                bool.FalseString);
            Console.WriteLine("{0} size:{1}; min : {2}; max: {3} ", typeof(int), sizeof(int), int.MinValue,
                int.MaxValue);
            Console.WriteLine("{0} size:{1}; min : {2}; max: {3} ", typeof(uint), sizeof(uint), uint.MinValue,
                uint.MaxValue);
            Console.WriteLine("{0} size:{1}; min : {2}; max: {3} ", typeof(long), sizeof(long), long.MinValue,
                long.MaxValue);
            Console.WriteLine("{0} size:{1}; min : {2}; max: {3} ", typeof(ulong), sizeof(ulong), ulong.MinValue,
                ulong.MaxValue);
            Console.WriteLine("{0} size:{1}; min : {2}; max: {3} ", typeof(short), sizeof(short), short.MinValue,
                short.MaxValue);
            Console.WriteLine("{0} size:{1}; min : {2}; max: {3} ", typeof(ushort), sizeof(ushort), ushort.MinValue,
                ushort.MaxValue);
            Console.WriteLine("{0} size:{1}; min : {2}; max: {3} ", typeof(byte), sizeof(byte), byte.MinValue,
                byte.MaxValue);
            Console.WriteLine("{0} size:{1}; min : {2}; max: {3} ", typeof(sbyte), sizeof(sbyte), sbyte.MinValue,
                sbyte.MaxValue);
            Console.WriteLine("{0} size:{1}; min : {2}; max: {3} ", typeof(decimal), sizeof(decimal), decimal.MinValue,
                decimal.MaxValue);
            Console.WriteLine("{0} size:{1}; min : {1}; max: {2} ", typeof(float), sizeof(float), float.MinValue,
                float.MaxValue);
            Console.WriteLine("{0} size:{1}; min : {1}; max: {2} ", typeof(double), sizeof(double), double.MinValue,
                double.MaxValue);
        }
    }
}