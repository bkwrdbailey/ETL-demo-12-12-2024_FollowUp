using ETL_demo_12_12_2024_FollowUp.Models;
using ETL_demo_12_12_2024_FollowUp.Services;

// Read a file's contents
CustomFileReader customFileReader = CustomFileReader.Instance;
List<string> inputs = customFileReader.ReadFileContents("input.csv");

//Console.WriteLine(string.Join(',', inputs));
//Console.Read();

// Parse a file's contents
CustomDataParser customDataParser = CustomDataParser.Instance;
Dictionary<int, Person> outputData =  customDataParser.ParseFileData(inputs);

// Display file contents to CLI
foreach (Person person in outputData.Values)
{
    Console.WriteLine(person.ToString());
}