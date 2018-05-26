namespace ZombieReport.CommandLine
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int[] statuses = {1, 4, 3, 2, 3, 2};
            string[] names = {"Bob", "Tim", "Tom", "Barb", "Kent", "Carlos"};
            while(counter < statuses.Length)
            {
                Console.Write(names[counter] + " ");

                switch (statuses[counter])
                {
                    case 1:
                        Console.WriteLine("Status: Alive");
                        break;
                    case 2:
                        Console.WriteLine("Status: Zombie");
                        break;
                    case 3:
                        Console.WriteLine ("Status: Dead");
                        break;
                    case 4:
                        Console.WriteLine("Status: Unknown");
                        break;
                }
                counter++;
            }

            counter = 0;
            do
            {
                Console.Write(names[counter] + " ");
                
                switch (statuses[counter])
                {
                    case 1:
                        Console.WriteLine("Status: Alive");
                        break;
                    case 2:
                        Console.WriteLine("Status: Zombie");
                        break;
                    case 3:
                        Console.WriteLine ("Status: Dead");
                        break;
                    case 4:
                        Console.WriteLine("Status: Unknown");
                        break;
                }
                counter++;
            } while(counter < statuses.Length);

            for(counter = 0; counter < statuses.Length; counter++)
            {
                Console.Write(names[counter] + " ");
                
                switch (statuses[counter])
                {
                    case 1:
                        Console.WriteLine("Status: Alive");
                        break;
                    case 2:
                        Console.WriteLine("Status: Zombie");
                        break;
                    case 3:
                        Console.WriteLine ("Status: Dead");
                        break;
                    case 4:
                        Console.WriteLine("Status: Unknown");
                        break;
                }
            }

            counter = 0;
            foreach(int status in statuses)
            {
                Console.Write(names[counter] + " ");
                
                switch (status)
                {
                    case 1:
                        Console.WriteLine("Status: Alive");
                        break;
                    case 2:
                        Console.WriteLine("Status: Zombie");
                        break;
                    case 3:
                        Console.WriteLine ("Status: Dead");
                        break;
                    case 4:
                        Console.WriteLine("Status: Unknown");
                        break;
                }
                counter++;
            }
        }
    }
}