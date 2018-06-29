using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> partitions = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            string[] command = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            while (command[0] != "3:1")
            {
                switch (command[0])
                {
                    case "merge":
                        int startIndex = int.Parse(command[1]);
                        int endIndex = int.Parse(command[2]);
                        if (endIndex >= partitions.Count)
                        {
                            endIndex = partitions.Count - 1;
                        }
                        if (startIndex >= partitions.Count)
                        {
                            startIndex = partitions.Count - 1;
                        }
                        if (startIndex < 0)
                        {
                            startIndex = 0;
                        }
                        Merge(partitions, startIndex, endIndex);
                        break;
                    case "divide":
                        int index = int.Parse(command[1]);
                        int partitionLength = int.Parse(command[2]);
                        Divide(partitions, index, partitionLength);
                        break;
                }
                command = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine(string.Join(" ", partitions));
        }

        public static void Merge(List<string> partitions, int startIndex, int endIndex)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = startIndex; i <= endIndex; i++)
            {
                sb.Append(partitions[i]);
            }
            partitions[startIndex] = sb.ToString();
            partitions.RemoveRange(startIndex + 1, endIndex - startIndex);
        }
        public static void Divide(List<string> partitions, int index, int partitionAmount)
        {
            string item = partitions[index];

            if (item.Length % partitionAmount != 0) // if it can't be divded exactly
            {
                int partitionLength = item.Length / partitionAmount;
                int remainder = item.Length % partitionLength;
                List<string> temp = new List<string>();
                while (item.Length != partitionLength + remainder + 1)
                {
                    temp.Add(item.Substring(0, partitionLength));
                    item = item.Substring(partitionLength);
                }
                temp.Add(item);
                partitions.InsertRange(index + 1, temp);
                partitions.RemoveAt(index);
            }
            else // if it can be divded exactly
            {
                int partitionLength = item.Length / partitionAmount;
                List<string> temp = new List<string>();
                while (item.Length > 0)
                {
                    temp.Add(item.Substring(0, partitionLength));
                    item = item.Substring(partitionLength);
                }
                partitions.InsertRange(index + 1, temp);
                partitions.RemoveAt(index);
            }
        }
    }
}
