class Program
{
    public static void printDublicat(int[] n)
    {
        int max = n.Max();
        int[] counts = new int[max + 1];
        for (int i = 0; i < n.Length; i++)
        {
            counts[n[i]]++;
            if (counts[n[i]] > 1) Console.WriteLine(n[i]);
        }
    }

    static void Main(string[] args) 
    {
        printDublicat(new int[] { 1, 6, 2, 4, 5, 7, 1, 55, 66, 77, 88, 99 });
    }
}