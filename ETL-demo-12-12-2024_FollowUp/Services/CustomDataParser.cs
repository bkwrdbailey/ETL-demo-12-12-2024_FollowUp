using ETL_demo_12_12_2024_FollowUp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETL_demo_12_12_2024_FollowUp.Services
{
    public class CustomDataParser
    {
        /// <summary>
        /// Takes in a List of String elements to then be parsed and converted to a Dictionary object for later use in displaying the file's tabular contents
        /// </summary>
        /// <param name="inputs"> List of string elements representing the individual lines of content of a file </param>
        /// <returns> Parsed file contents that have been converted to a Dictionary Collection </returns>
        public Dictionary<int, Person> ParseFileData(List<string> inputs)
        {
            Dictionary<int, Person> personDetails = new Dictionary<int, Person>();

            for (int i = 0; i < inputs.Count; i++)
            {
                //Console.WriteLine(inputs[i]);
                var innerElements = inputs[i].Split(',');

                // Convert the split inner string elements into the proper Data Types to be used in the Person Constructor
                Person newPerson = new Person(Convert.ToInt32(innerElements[0]), innerElements[1], Convert.ToInt32(innerElements[2]), innerElements[3]);

                personDetails.Add(Convert.ToInt32(innerElements[0]), newPerson);
            }

            return personDetails;
        }
    }
}
