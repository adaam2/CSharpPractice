using System;
using System.IO;
using Microsoft.VisualBasic.FileIO;

namespace CSharpPractice
{
    /// <summary>
    /// Various System.IO bits and pieces
    /// </summary>
    class IO
    {
        public IO()
        {
            //ReadFile("textFiles/sample1.txt");
            CommaSeparatedValuesIteration("textFiles/FL_insurance_sample.csv");
        }
        private void ReadFile(string filePath)
        {
            string fullyQualifiedPath = Path.GetFullPath(filePath);
            using (StreamReader reader = new StreamReader(fullyQualifiedPath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
        private void CommaSeparatedValuesIteration(string pathToCSV)
        {
            string fullPath = Path.GetFullPath(pathToCSV);
            using (TextFieldParser parser = new TextFieldParser(fullPath))
            {
                parser.Delimiters = new string[] { "," };
                while (true)
                {
                    string[] parts = parser.ReadFields();
                    if (parts == null)
                    {
                        break;
                    }
                    Console.WriteLine("{0} field(s)", parts.Length);
                }
            }
        }
    }
}
