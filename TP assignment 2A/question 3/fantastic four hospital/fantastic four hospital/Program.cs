using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace fantastic_four_hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            //Patient management
            string patientfiles = "Patient.txt";
            string fullname, dateofbirth, gender, contactinfo, searchtext;

            for (int i = 0; i < 3; i++)
            {
                using (StreamWriter a = new StreamWriter(patientfiles, true))
                {
                    Console.WriteLine("Enter your full name: ");
                    fullname = Console.ReadLine();

                    Console.WriteLine("Enter your date of birth: ");
                    dateofbirth = Console.ReadLine();

                    Console.WriteLine("Enter your gender: ");
                    gender = Console.ReadLine();

                    Console.WriteLine("Enter your emergency contact: ");
                    contactinfo = Console.ReadLine();


                    a.WriteLine("name: " + fullname + " date of birth: " + dateofbirth + " gender: " + gender + " emergency contact: " + contactinfo);
                }
            }

            Console.WriteLine("Your file was created ");
            Console.WriteLine("");

            //search for patient
            Console.Write("search by patient name: ");
            searchtext = Console.ReadLine();

            using (StreamReader a = new StreamReader(patientfiles))
            {
                string line;
                line = a.ReadLine();
                while (line != null)
                {
                    if (line.ToLower().Contains(searchtext.ToLower()))
                    {
                        Console.WriteLine(line);
                        break;
                    }
                    line = a.ReadLine();
                }
                if (line == null)
                {
                    Console.WriteLine("No matching patient found.");
                }

            }

            Console.WriteLine("");

            //viewing patient files
            Console.WriteLine("view all patients");
            string txt = File.ReadAllText(patientfiles);
            Console.WriteLine(txt);
            Console.WriteLine(" ");

            //Doctor Management
            string doctorfiles = "Doc.txt";
            string name, specialization, contact, availabitity;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Doctors section");
                Console.WriteLine("");
                Console.WriteLine("Enter your full name: ");
                name = Console.ReadLine();

                Console.WriteLine("Enter what are your medical specialties or sub-specialties: ");
                specialization = Console.ReadLine();

                Console.WriteLine("Enter your contact number: ");
                contact = Console.ReadLine();

                Console.WriteLine("Enter the days you will be in: ");
                availabitity = Console.ReadLine();

                using (StreamWriter b = new StreamWriter(doctorfiles, true))
                {
                    b.WriteLine("name : " + name + " specialization:" + specialization + " contact: " + contact + " available: " + availabitity);
                }
 
            }
            
            Console.WriteLine("Management file was created ");
            Console.WriteLine("");


            //Apointment Management
            string appointmentfiles = "appointments.txt";
            string initials, dateofappointment, time, phonenumber;

            Console.WriteLine("Appointment section");
            Console.WriteLine("");
            Console.WriteLine("Enter your initial: ");
            initials = Console.ReadLine();

            Console.WriteLine("Enter the date of your appointment: ");
            dateofappointment = Console.ReadLine();

            Console.WriteLine("Enter the time of your appointment: ");
            time = Console.ReadLine();

            Console.WriteLine("Enter your contact number: ");
            phonenumber = Console.ReadLine();

            using (StreamWriter c = new StreamWriter(appointmentfiles))
            {
                c.WriteLine("inintial: " + initials + " date:" + dateofappointment + " time:" + time + " contactno:" + phonenumber );
            }
            Console.WriteLine("Appointment file was created ");
            Console.WriteLine("");


            //Billing system
            string billingfiles = "billing.txt";
            string patientID, medicalAid, totalAmount, insurancenumber;

            Console.WriteLine("Billing section");
            Console.WriteLine("");
            Console.WriteLine("Enter your refernce number: ");
            patientID = Console.ReadLine();

            Console.WriteLine("Enter your medical aid provider name: ");
            medicalAid = Console.ReadLine();

            Console.WriteLine("Enter amount covered by health insurance: ");
            totalAmount = Console.ReadLine();

            Console.WriteLine("Enter your insurance department phone number: ");
            insurancenumber = Console.ReadLine();

            using (StreamWriter d = new StreamWriter(billingfiles))
            {
                d.WriteLine("reference :" + patientID + "medical aid name:" + medicalAid + "totalamount:" + totalAmount + "phonenumber:" + insurancenumber);
      
            }
            Console.WriteLine("Billing system file was created ");
            Console.WriteLine("");
            Console.Read();

        }
    }
}
