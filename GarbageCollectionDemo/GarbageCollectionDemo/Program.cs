namespace GarbageCollectionDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            long num1 = GC.GetTotalMemory(false);
            {
                int[] Values= new int[500000];
                Values = null;
            }
            long num2 = GC.GetTotalMemory(false);
            {
                GC.Collect();
            }
            long num3 = GC.GetTotalMemory(false);
            {
                Console.WriteLine(num1);
                Console.WriteLine(num2);
                Console.WriteLine(num3);
            }
            Console.WriteLine("---------------------");
            long byte1 = GC.GetTotalMemory(false);

            byte[] memory = new byte[1000*100*10];

            memory[0]=1;

            long byte2 = GC.GetTotalMemory(false);
            long byte3 = GC.GetTotalMemory(true);

            Console.WriteLine(byte1);
                Console.WriteLine(byte2);
            Console.WriteLine("different");
            Console.WriteLine(byte2-byte1);
            Console.WriteLine(byte3);
            Console.WriteLine("different");
            Console.WriteLine(byte3-byte2);
            Console.ReadLine();
        }
    }
}