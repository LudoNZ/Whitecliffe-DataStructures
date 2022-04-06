using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Searching_Algorithms
{
    //Will Create an Array from a specified text file
    class ObtainRecords
    {
        public static void Build(string resource, int size)
        {
            //Use path to the records.txt here
            string path = @$"Files\{resource}.txt";

            Program.movieList = new string[size];

            //Read file using streamreader. (reads Line by Line)
            if (File.Exists(path))
            {
                using (StreamReader file = new StreamReader(path))
                {
                    int counter = 0;

                    //to store each line of the file
                    string title;

                    while ((title = file.ReadLine()) != null)
                    {
                        //adding movie Title to the list
                        Program.movieList[counter] = title.Trim();

                        counter++;
                    }

                    //close .txt File 
                    file.Close();

                    Console.WriteLine($"**Movie Titles have been recorded successfully**\n   " +
                        $"{counter} movie Titles in database");


                }
            }
        }

        public static void PrintList(string[] list)
        {
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

        }
    }
}
