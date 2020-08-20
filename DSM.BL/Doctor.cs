using System;

namespace DSM.BL
{
    public class Doctor
    {
        public Doctor(string name , string whatsappNumber , string field1 , string field2, string field3, string field4)
        {
            Name = name;
            WhatsappNumber = whatsappNumber;
            Field1 = field1;
            Field2 = field2;
            Field3 = field3;
            Field4 = field4;
        }


        public bool Validate()
        {
            bool isValid = true;
            if (  Name   == "0"
               || Field1 == "0" 
               || Field2 == "0" 
               || Field3 == "0" 
               || Field4 == "0" )
            {
                isValid = false;
            }

            return isValid;
        }

        public string Name { get; }
        public string WhatsappNumber { get; }

        public string Field1 { get; }
        public string Field2 { get; }
        public string Field3 { get; }
        public string Field4 { get; }






    }
}
