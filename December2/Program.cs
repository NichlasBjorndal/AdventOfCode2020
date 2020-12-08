using System;
using System.Collections.Generic;
using System.Linq;

namespace December2
{
    class Program
    {
        static void Main(string[] args)
        {

            int partOnecounter = 0;
            int partTwocounter = 0;


            string line;

            // Read the file and display it line by line.  
            string filePath = System.IO.Path.GetFullPath("input.txt");
            System.IO.StreamReader file =
                new System.IO.StreamReader(filePath);
            while ((line = file.ReadLine()) != null)
            {
                var lineParts = line.Split(':');

                var limits = lineParts[0].Split('-');
                var lowerLimit = int.Parse(limits[0]);

                var secondPartOfLimit = limits[1].Split(' ');
                var upperLimit = int.Parse(secondPartOfLimit[0]);

                char delimiter = secondPartOfLimit[1].ToCharArray()[0];

                var password = lineParts[1].Trim();


                var count = password.Count(x => x == delimiter);

                if(count >= lowerLimit && count <= upperLimit)
                {
                    partOnecounter++;
                }

                if (password[lowerLimit-1] == delimiter ^ password[upperLimit - 1] == delimiter)
                {
                    partTwocounter++;
                }


            }

            file.Close();

            Console.WriteLine($"Part 1: There is current {partOnecounter} correct passwords");
            Console.WriteLine($"Part 2: There is current {partTwocounter} correct passwords");
        }

    }
}
