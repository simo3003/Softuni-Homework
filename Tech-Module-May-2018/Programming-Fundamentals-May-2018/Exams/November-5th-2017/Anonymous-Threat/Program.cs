using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anonymous_Threat
{
    class Program
    {
        // 90/100
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
                        if (startIndex < 0)
                        {
                            startIndex = 0;
                        }
                        if (startIndex > partitions.Count - 1 || endIndex < 0)
                        {
                            command = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                            continue;
                        }
                        if (endIndex >= partitions.Count)
                        {
                            endIndex = partitions.Count - 1;
                        }
                        Merge(partitions, startIndex, endIndex);
                        break;
                    case "divide":
                        int index = int.Parse(command[1]);
                        int partitionAmount = int.Parse(command[2]);
                        Divide(partitions, index, partitionAmount);
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
            partitions.RemoveRange(startIndex + 1, endIndex - startIndex); // remove the items after the item until the endIndex
        }
        public static void Divide(List<string> partitions, int index, int partitionAmount)
        {
            if (partitionAmount == 0)
            {
                partitions.RemoveAt(index);
                return;
            }

            string item = partitions[index];
            int partitionLength = item.Length / partitionAmount;

            if (item.Length % partitionAmount != 0) // if it can't be divded exactly
            {
                List<string> temp = new List<string>();
                for (int i = 0; i < partitionAmount-1; i++)
                {
                    temp.Add(item.Substring(0, partitionLength));
                    item = item.Remove(0, partitionLength);
                }
                temp.Add(item); // add the last partition
				partitions.RemoveAt(index);
                partitions.InsertRange(index, temp);
            }

            else // if it can be divded exactly
            {
                List<string> temp = new List<string>();
                while (item.Length > 0)
                {
                    temp.Add(item.Substring(0, partitionLength));
                    item = item.Substring(partitionLength);
                }
                partitions.InsertRange(index + 1, temp); // insert it AFTER the original item
                partitions.RemoveAt(index); // remove the original item
            }
        }
    }
}
