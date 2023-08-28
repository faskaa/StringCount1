namespace StringCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "Hello, this is my count task. Good days!";
            int count = 1;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i]==' ')
                {
                    count++;
                }
            }
            Console.WriteLine(count);







        }
    }
}