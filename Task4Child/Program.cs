namespace Task4Child
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                return;
            }
            using (FileStream fs = new FileStream(args[0], FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    string text = sr.ReadToEnd();
                    string[] t = text.Split(args[1]);
                    Console.WriteLine($"Result: {t.Length - 1}");
                }
            }
            Console.ReadLine();
        }
    }
}