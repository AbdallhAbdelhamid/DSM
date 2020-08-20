using System.Collections.Generic;
using System.IO;

using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("DSM.DALTests")]


namespace DSM.DAL
{
    internal class CsvParser
    {
        internal CsvParser(string fileName)
        {
            _fileName = fileName;
            FileExists = File.Exists(_fileName);
        }

        /// <summary>
        /// Reads All Lines from The CSV File
        /// </summary>
        /// <returns>
        /// IEnumerable >string> of comma separated lines
        /// </returns>
        internal IEnumerable<string> ReadCsvFile()
        {
            var CsvLines = new List<string>();
            using (StreamReader reader = new StreamReader(_fileName))
            {
                string csvLine;
                while ((csvLine = reader.ReadLine()) != null)
                {
                    CsvLines.Add(csvLine);
                }
            }
            return CsvLines;
        }

        /// <summary>
        /// Formats Comma Separated Lines into a Dictionary Collection.
        /// </summary>
        /// <param name="commaSepartedStrings">  
        /// </param>
        /// <returns>
        /// Dictionary with First element is The key.
        /// </returns>
        internal Dictionary<string, List<string>> FormatData(IEnumerable<string> commaSepartedStrings)
        {
            var doctorsData = new Dictionary<string, List<string>>();

            foreach (string line in commaSepartedStrings)
            {
                var data = line.Split(',');
                var salaryData = new List<string>
                {
                    data[1],
                    data[2],
                    data[3],
                    data[4]
                };

                doctorsData.Add(data[0], salaryData);

            }

            return doctorsData;
        }

        /// <summary>
        /// Equals True if file exists and can be opened.
        /// Otherwise Equals false
        /// </summary>
        public bool FileExists { get; }
        private string _fileName;

    }

}
