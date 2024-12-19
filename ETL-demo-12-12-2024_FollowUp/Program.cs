using ETL_demo_12_12_2024_FollowUp.Models;
using ETL_demo_12_12_2024_FollowUp.Services;

// Read a file's contents
CustomFileReader customFileReader = CustomFileReader.Instance;
List<string> inputs = customFileReader.ReadFileContents("input.csv");

// Parse a file's contents
CustomDataParser customDataParser = CustomDataParser.Instance;
Dictionary<int, Person> outputData =  customDataParser.ParseFileData(inputs);

// Instantiate CustomLoggers for Console or specified File logging
CustomLogger consoleLogger = LoggerFactory.getLogger("App.class");
CustomLogger fileLogger = LoggerFactory.getLogger("App.class", "out.log");

consoleLogger.Log("This is a Console log");
fileLogger.Log("This is a File log");