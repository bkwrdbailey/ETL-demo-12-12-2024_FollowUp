using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETL_demo_12_12_2024_FollowUp.Services
{
    public class LoggerFactory
    {
        private LoggerFactory() { }
        private static HashSet<CustomLogger> existingLoggers = new HashSet<CustomLogger>();

        /// <summary>
        /// Retrieves a custom logger if it already exists within the existing loggers Collection, otherwise it newly creates it
        /// and adds it to the existing loggers Collection
        /// </summary>
        /// <param name="className">The name of the class that the logger should be associated with</param>
        /// <param name="fileName">The name of the file the logger should write it, but if no value is specified than it will default to an empty string</param>
        /// <returns></returns>
        public static CustomLogger getLogger(string className, string fileName="")
        {
            foreach (CustomLogger logger in existingLoggers)
            {
                if (logger.ClassName.Equals(className) && logger.FileName.Equals(fileName)) { return logger; }
            }

            CustomLogger newLogger = new CustomLogger(className, fileName);
            existingLoggers.Add(newLogger);
            return newLogger;
        }
    }
}
