using System;
using System.Data;

namespace DSM.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            var doctorRepository = new BL.DoctorRepository();

            while (true)
            {

                Console.WriteLine("Enter Doctor Name to search... or type * show * All Names..");
                var input = Console.ReadLine();

                switch (input.ToLower())
                {
                    case "show":
                        {
                            ShowAll();
                            break;
                        }
                    default:
                        {
                            var doc = doctorRepository.GetDoctor(input);

                            if (doc.Validate())
                            {
                                Console.WriteLine();
                                Console.WriteLine($"Yes, Doctor {input} exists!");
                                Console.WriteLine(doc.Name);
                                Console.WriteLine(doc.WhatsappNumber);
                                Console.WriteLine(doc.Field1);
                                Console.WriteLine(doc.Field2);
                                Console.WriteLine();

                            }
                            else
                            {
                                Console.WriteLine($"Sorry , {input} isn't here..");
                                Console.WriteLine();

                            }
                            break;
                        }
                }
            }


        }

        static void ShowAll()
        {
            var doctorRepository = new BL.DoctorRepository();
            foreach(string docName in doctorRepository.GetAllDoctorsNames() )
            {
                Console.WriteLine(docName);
            }
            Console.WriteLine();

        }


    }

}
