namespace Quiz
{

    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input N :");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input K :");
            int K = int.Parse(Console.ReadLine());
            int i = 0;
            int check = 1;
            int check2 = 1;
            int num1 = 1;
            while (i <= K)
            {
                Console.WriteLine("Please input gender :");
                int gender = int.Parse(Console.ReadLine());
                Console.WriteLine("Please input score1 :");
                int score1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Please input score2 :");
                int score2 = int.Parse(Console.ReadLine());

                if (score1 <= 10 && score2 <= 10)
                {
                    if (score1 < score2)
                    {
                        while (num1 <= K)
                        {
                            Console.Write("result=");
                            Console.Write(num1);
                            Console.Write(" ");
                            Console.WriteLine("2");
                        }

                    }
                    else
                    {
                        while (num1 <= K)
                        {
                            Console.Write("result=");
                            Console.Write(num1);
                            Console.WriteLine("1");
                        }

                    }
                }
                i++;
                num1++;
            }







        }
    }
}
