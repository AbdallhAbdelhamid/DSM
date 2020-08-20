using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using System.Linq;

[assembly: InternalsVisibleTo("DSM.DALTests")]

namespace DSM.DAL
{
    public static class Database
    {
        static Database()
        {
            string fileName = @"E:\CSharpProjects\Book1.csv";
            GetAllData(fileName);
        }
  
        public static IEnumerable<string> GetDataLine(string stringId)
        {
            var list = new List<string>();

            if (Doctors.ContainsKey(stringId))
            {
                list.Add(stringId);
                foreach (var value in Doctors[stringId])
                {
                    list.Add(value);
                }
                return list;
            }
            else
                return null;
            
        }

        public static void GetAllData(string fileName)
        {
            CsvParser reader = new CsvParser(fileName);  // open file
            var unformattedData = reader.ReadCsvFile().ToList();              // read csv lines
            Doctors = reader.FormatData(unformattedData);              // save doctors data into dictionary
        }

       public static Dictionary<string, List<string>> Doctors
        {
            get;
            private set;
        }

    }

}
