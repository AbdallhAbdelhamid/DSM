using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DSM.BL
{
    public  class DoctorRepository
    {
        public  Doctor GetDoctor(string name)
        {

            var dataLine = DAL.Database.GetDataLine(name);
            if (dataLine != null)
            {
                var entry = dataLine.ToList();
                return new Doctor(entry[0], "01143341547", entry[1], entry[2], entry[3], entry[4]);
            }

            else
            {
                return new Doctor("0", "0", "0", "0", "0", "0");
            }

         
        }


        public IEnumerable<string> GetAllDoctorsNames()
        {
            return DAL.Database.Doctors.Keys;
        }

    }
}
