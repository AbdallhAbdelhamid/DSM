using DSM.BL;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DSM.BLTests
{
    public class DoctorTest
    {

        [Fact]
        public void DoctorValidateReturnsTrue()
        {
            // arrange
            var docRepo = new DoctorRepository();
            var doc = docRepo.GetDoctor("Dodo Ahmed");
            var expected = true;

            // act
            var actual = doc.Validate();

            // assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void DoctorValidateReturnsFalse()
        {
            // arrange
            var docRepo = new DoctorRepository();
            var doc = docRepo.GetDoctor("None Existed Name");
            var expected = false;

            // act
            var actual = doc.Validate();

            // assert
            Assert.Equal(expected, actual);

        }
    }
}
