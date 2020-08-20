using DSM.DAL;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace DSM.DALTests
{
    public class CsvParserTest
    {
        [Fact]
        public void CsvFileExistsPropReturnsTrue()
        {
            // arragnge
            string fileName = @"E:\CSharpProjects\Book1.csv";
            CsvParser parser = new CsvParser(fileName);
            bool expected = true;

            // act
            bool actual = parser.FileExists;

            // assert
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void CsvFileExistsPropReturnsFalse()
        {
            // arragnge
            string fileName = @"E:\CSharpProjects\Book2.csv"; // invalid path to test.
            CsvParser parser = new CsvParser(fileName);
            bool expected = false;

            // act
            bool actual = parser.FileExists;

            // assert
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void ReadCsvFileReturnsCorrectValues()
        {
            // arrange
            string fileName = @"E:\CSharpProjects\Book1.csv";
            CsvParser parser = new CsvParser(fileName);

            List<string> expected = new List<string>
            {
                "Dodo Ahmed,10,20,30,40",
                "Amr Mohammed,1,2,3,4",
                "Memo Mahmoud,100,200,300,400"
            };


            // act
            parser.ReadCsvFile();
            List<string> actual = parser.ReadCsvFile().ToList();

            // assert
            Assert.Equal(expected.Count, actual.Count);

            for (int i = 0; i < actual.Count; i++)
            {
                Assert.Equal(expected[i], actual[i]);
            }
        }


        [Fact]
        public void FormatDataValidTest()
        {
            // arrange
            string fileName = @"E:\CSharpProjects\Book1.csv";
            CsvParser parser = new CsvParser(fileName);
            var expected = new Dictionary<string, List<string>>
                {
                  {"Dodo Ahmed",new List<string>{ "10" ,"20" ,"30" ,"40" }        },
                  {"Amr Mohammed",new List<string>{ "1" ,"2" ,"3" ,"4" }            },
                  {"Memo Mahmoud",new List<string>{ "100" ,"200" ,"300" ,"400" }    }
                };


            // act
            var actual = parser.FormatData(parser.ReadCsvFile());

            // Assert
            Assert.Equal(expected["Amr Mohammed"], actual["Amr Mohammed"]);
            Assert.Equal(expected["Dodo Ahmed"]  , actual["Dodo Ahmed"]);
            Assert.Equal(expected["Memo Mahmoud"], actual["Memo Mahmoud"]);
        }






    }
}
