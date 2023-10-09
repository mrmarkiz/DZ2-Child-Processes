namespace Task3Child
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if(args.Length != 3)
            {
                return;
            }
            double res = 0;
            switch(args[2])
            {
                case "+":
                    res = int.Parse(args[0]) + int.Parse(args[1]);
                    break;
                case "-":
                    res = int.Parse(args[0]) - int.Parse(args[1]);
                    break;
                case "*":
                    res = long.Parse(args[0]) * int.Parse(args[1]);
                    break;
                case "/":
                    res = double.Parse(args[0]) / int.Parse(args[1]);
                    break;
            }
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}