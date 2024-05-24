    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine(" Enter an expression ");

                string input = Console.ReadLine();
                string[] data = input.Split(' ');
                string operation = data[1];
                int x = int.Parse(data[0]), y = int.Parse(data[2]), result = 0;

                switch (operation) 
                {
                    case "+":
                        result = x + y;
                    break;
                    case "-":
                        result = x - y;
                    break;
                    case "*":
                        result = x * y;
                    break;
                    case "/":
                        result = x / y;
                    break;
                }
                Console.WriteLine(" Result:" + result);
            }
        }
    }
