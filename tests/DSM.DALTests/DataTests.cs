using DSM.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;
using Xunit.Sdk;

namespace DSM.DALTests
{
    public class DataTests
    {
        [Fact]
        public void GetAllDataTestValid()
        {
            // arrange
            var expected = new List<string> { "Dodo Ahmed", "10", "20", "30", "40" };

            // act
            var actual = Database.GetDataLine("Dodo Ahmed").ToList();
            // assert

            Assert.Equal(expected[0], actual[0]);
            Assert.Equal(expected[1], actual[1]);
            Assert.Equal(expected[2], actual[2]);
            Assert.Equal(expected[3], actual[3]);
            Assert.Equal(expected[4], actual[4]);



        }

    }
}
