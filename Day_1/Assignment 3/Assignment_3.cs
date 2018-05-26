
namespace ZombieReport.CommandLine
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int[] statuses = {1, 2, 3, 4, 5, 6};
            string[] names = {"Bob", "Tim", "Tom", "Barb", "Kent", "Carlos"};
            for(counter = 0; counter < statuses.Length; counter++)
            {
                string status = GetStatusDescription(statuses[counter], names[counter]);
                WriteStatus(status);
            }
        }

        private static void WriteStatus(string status)
        {
            Console.WriteLine(status);
        }

        private static string GetStatusDescription(int status, string name)
        {
            string statusDescription = string.Empty;
            switch (status)
            {
                case 1:
                    statusDescription = "Status: Alive";
                    break;
                case 2:
                    statusDescription = "Status: Zombie";
                    break;
                case 3:
                    statusDescription = "Status: Dead";
                    break;
                case 4:
                    statusDescription = "Status: Unknown";
                    break;
            }
            return name + " " + statusDescription;
        }
    }
}