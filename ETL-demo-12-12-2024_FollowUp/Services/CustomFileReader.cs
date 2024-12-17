using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETL_demo_12_12_2024_FollowUp.Services
{
    public sealed class CustomFileReader
    {
        // Encapsulated field that gets instantiated during initial project Startup so to avoid need to assign a new Instance during runtime
        private static readonly CustomFileReader instance = new CustomFileReader();

        static CustomFileReader() { }

        private CustomFileReader() { }

        // Public Property for getting the same class instance no matter what external functionality that calls this to enforce the Singleton Design Pattern
        public static CustomFileReader Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Searches for a file based on the filename passed in and inserts the contents of the file into a List<string> Collection
        /// </summary>
        /// <param name="fileName"> The name of a file that is supposed to have its contents read </param>
        /// <returns> A List of string elements that represent each individual line of text within the specified file </returns>
        public List<string> ReadFileContents(string fileName)
        {
            List<string> fileContents = new List<string>();
            try
            {
                using StreamReader reader = new StreamReader(fileName);
                string line = reader.ReadLine();
                while (true)
                {
                    line = reader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    else
                    {
                        fileContents.Add(line);
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"An exception was caught when trying to read the contents of the passed in file {fileName} :: {ex}");
            }

            return fileContents;
        }
    }
}
