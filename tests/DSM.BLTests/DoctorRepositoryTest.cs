using System;
using Xunit;
using DSM.BL;
using Xunit.Sdk;

namespace DSM.BLTests
{
    public class DoctorRepositoryTest
    {
        [Fact]
        public void GetDoctorReturnWithValidInput()
        {
            // arrange
            var docRepo = new DoctorRepository();
            var expected = new Doctor("Dodo Ahmed", "01143341547"  ,"10"  ,"20", "30" ,"40" );
            // act
            var actual = docRepo.GetDoctor("Dodo Ahmed");

            // assert

            Assert.Equal(expected.Name, actual.Name);
            Assert.Equal(expected.WhatsappNumber, actual.WhatsappNumber);
            Assert.Equal(expected.Field1, actual.Field1);
            Assert.Equal(expected.Field2, actual.Field2);
            Assert.Equal(expected.Field3, actual.Field3);
            Assert.Equal(expected.Field4, actual.Field4);

        }


    }
}
