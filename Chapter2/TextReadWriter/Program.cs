using System;
using System.IO;

namespace TextReadWriter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string filePath = "C:\\Users\\Student\\source\\repos\\.NetProjects\\C#8.0And.NetCore3.0\\Chapter2\\Chapter2\\Device.txt";

            //// Using stream reader to read the contents of a file
            //using (StreamReader reader = new StreamReader(filePath))
            //{
            //    Console.WriteLine("Reading file using StreamReader:");
            //    string contents = reader.ReadToEnd();
            //    Console.WriteLine(contents);
            //    Console.ReadLine();
            //} // File is automatically closed here

            //// Reading all file contents at once using File.ReadAllText
            //Console.WriteLine("\nReading file using File.ReadAllText:");
            //string fileContents = File.ReadAllText(filePath);
            //Console.WriteLine(fileContents);
            //Console.ReadLine();

            //// Read file as an array of lines using File.ReadAllLines
            //Console.WriteLine("\nReading file using File.ReadAllLines:");
            //string[] lines = File.ReadAllLines(filePath);
            //foreach (string line in lines)
            //{
            //    Console.WriteLine(line);
            //}
            //Console.ReadLine();

            //// Read file one line at a time using StreamReader.ReadLine
            //Console.WriteLine("\nReading file one line at a time using StreamReader.ReadLine:");
            //using (StreamReader reader = new StreamReader(filePath))
            //{
            //    string line;
            //    while ((line = reader.ReadLine()) != null)
            //    {
            //        Console.WriteLine(line);
            //    }
            //    Console.ReadLine();
            //} // File is automatically closed here

            //// Using stream writer to write to a file
            //string outputFilePath = "C:\\Users\\Student\\source\\repos\\.NetProjects\\C#8.0And.NetCore3.0\\Chapter2\\Chapter2\\greeting.txt";
            //File.WriteAllText(outputFilePath, "Hello, World! This is a greeting from the TextReadWriter program.\n");

            //// Append additional text to the file
            //string logFile = "C:\\Users\\Student\\source\\repos\\.NetProjects\\C#8.0And.NetCore3.0\\Chapter2\\Chapter2\\log.txt";
            //File.AppendAllText(logFile, "This is a log entry.\n");

            //// Writing multiple lines to a file using StreamWriter
            //string[] tasks = { "Buy groceries", "Walk the dog", "Finish homework" };
            //string tasksFile = "C:\\Users\\Student\\source\\repos\\.NetProjects\\C#8.0And.NetCore3.0\\Chapter2\\Chapter2\\tasks.txt";

            //using StreamWriter writer = new StreamWriter(tasksFile, append: false);

            //foreach (string task in tasks)
            //{
            //    writer.WriteLine(task);
            //}

            // Log a new event
            string logFile = "C:\\Users\\Student\\source\\repos\\.NetProjects\\C#8.0And.NetCore3.0\\Chapter2\\Chapter2\\log.txt";
            string timestamp = DateTime.Now.ToString("HH:mm:ss");

            File.AppendAllText(logFile, $"[{timestamp}] Application started\n");

            Console.WriteLine("Event logged.\n");

            // Read back every logged event
            Console.WriteLine("Event history:");

            using StreamReader reader = new StreamReader(logFile);
            string line;

            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }

            // Count the logged events
            string[] allLines = File.ReadAllLines(logFile);
            Console.WriteLine($"\nTotal events logged: {allLines.Length}");
        }
    }
}
