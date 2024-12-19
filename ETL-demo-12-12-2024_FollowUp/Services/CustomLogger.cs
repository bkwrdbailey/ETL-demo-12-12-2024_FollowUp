using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETL_demo_12_12_2024_FollowUp.Services
{
    public class CustomLogger
    {
        public string ClassName { get; private set; }
        public string FileName { get; private set; }

        /// <summary>
        /// Constructor for creating a CustomLogger Object that will either log to an External File or to the Console based on whether
        /// a fileName value was provided or not respectively
        /// </summary>
        /// <param name="className">The name of the Class that instantiated the CustomLogger Object</param>
        /// <param name="fileName">The name of the file to log to, set to the default value of an EMPTY string if no value is passed in</param>
        public CustomLogger(string className, string fileName = "")
        {
            ClassName = className;
            FileName = fileName;
        }

        /// <summary>
        /// Takes in a message object, formats its contents, and logs the newly formatted message to the Console or a File if one was
        /// provided on CustomLogger Object Instantiaton
        /// </summary>
        /// <param name="message"></param>
        public void Log(object message)
        {
            string formattedMessage = $"[INFO] {DateTime.Now} :: {message}";
            if (String.IsNullOrEmpty(FileName))
            {
                Console.WriteLine(formattedMessage);
            }
            else
            {
                try
                {
                    // Using statement will automatically release the StreamWriter resource once its finished being used to avoid the need to manually clean it up
                    using (StreamWriter writer = new StreamWriter(FileName, true))
                    {
                        writer.WriteLine(formattedMessage);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[ERROR] {DateTime.Now} :: Exception was caught :: {ex}");
                }
            }
        }
    }
}
